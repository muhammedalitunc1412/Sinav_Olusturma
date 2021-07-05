using HtmlAgilityPack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SınavOluşturma.Entities;
using SınavOluşturma.Services.Abstract;
using SınavOluşturma.WEBUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOluşturma.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IQuestionService _questionService;
        private ITestService _testService;

        public HomeController(IQuestionService questionService, ITestService testService)
        {
            this._questionService = questionService;
            this._testService = testService;
        }     

        public static List<string> getLinks(string url, string xpath, string toPath = "")
        {

            List<string> links = new List<string>();
            HtmlNode[] nodes = getNodesByXPath(url, xpath);
            for (int i = 0; i < 5; i++)
            {
                links.Add(toPath + nodes[i].FirstChild.Attributes["href"].Value.ToString());
            }
            return links;
        }
        public static HtmlNode[] getNodesByXPath(string url, string xpath)
        {
            HtmlWeb web = new HtmlWeb();
            List<string> links = new List<string>();
            HtmlDocument doc = web.Load(url);
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes(xpath).TakeWhile(item => !item.InnerHtml.Contains("https://www.wired.com/newsletter?sourceCode=BottomStories")).ToArray();


            return nodes;
        }

        public IActionResult Index()
        {
            SetViewBags();

            List<Test> tests = new List<Test>();

            List<string> links = getLinks("https://www.wired.com/most-recent", "/html/body/div[3]/div/div[3]/div/div[2]/div/div[1]/div/div/ul/li", "https://www.wired.com");


            for (int i = 0; i < 5; i++)
            {
                HtmlNode[] header = getNodesByXPath(links[i], "//h1");                

                HtmlNode[] content = getNodesByXPath(links[i], "//article//p");
                string a = "";
                for (int j = 0; j < content.Length; j++)
                {
                    a += "<p>" + content[j].InnerHtml + "</p>";
                }
                tests.Add(new Test { title = header[0].InnerHtml.ToString(), content = a });
            }
            var model = new HomeViewModel { Tests = tests.ToArray() };
            return View(model);


        }

        [Authorize]
        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            string key = Guid.NewGuid().ToString();
            Test test = new Test
            {
                title = model.title,
                content = model.content,
                userId = Convert.ToInt32(HttpContext.Session.GetInt32("userId")),
                key = key,
                createdDate = DateTime.Now
            };
            _testService.AddTest(test);
            Test currentTest = _testService.GetTestWithKey(key);
            _questionService.SaveQuestions(model.Questions, currentTest);
            return RedirectToAction("Index", "Test");
        }
        [Authorize]
        public void SetViewBags()
        {

            List<SelectListItem> options = new List<SelectListItem> {

                new SelectListItem { Text="Doğru Cevabı Seçiniz", Value="", Selected=true},
                new SelectListItem { Text="A", Value="One"},
                new SelectListItem { Text="B", Value="Two"},
                new SelectListItem { Text="C", Value="Three"},
                new SelectListItem { Text="D", Value="Four"}
            };
            ViewBag.options = options;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
