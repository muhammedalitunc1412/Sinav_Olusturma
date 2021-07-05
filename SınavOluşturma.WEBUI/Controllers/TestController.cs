using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SınavOluşturma.Entities;
using SınavOluşturma.Services.Abstract;
using SınavOluşturma.WEBUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOluşturma.WEBUI.Controllers
{
    public class TestController : Controller
    {
        private IQuestionService _questionService;
        private ITestService _testService;

        public TestController(IQuestionService questionService, ITestService testService)
        {
            this._questionService = questionService;
            this._testService = testService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = new TestViewModel
            {
                TestList = _testService.GetTestListWithUser(Convert.ToInt32(HttpContext.Session.GetInt32("userId")))
            };
            return View(model);
        }
        [Authorize]
        public IActionResult DeleteTest(int id)
        {
            var test = _testService.GetTestWithId(id);
            _testService.DeleteTest(test);
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult SolveTest(int id)
        {
            var test = _testService.GetTestWithId(id);
            List<Question> questions = _questionService.GetTestQuestion(id);
            var model = new TestViewModel { QuestionList = questions, Test = test };
            return View(model);
        }
    }
}
