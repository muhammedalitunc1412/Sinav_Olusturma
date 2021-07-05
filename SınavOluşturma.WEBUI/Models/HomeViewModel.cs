using SınavOluşturma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOluşturma.WEBUI.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Tests = new Test[5];
            Questions = new Question[4];
        }
        public Question[] Questions { get; set; }
        public Test[] Tests { get; set; }

        public int ContentsId { get; set; }

        public string title { get; set; }
        public string content { get; set; }


    }
}
