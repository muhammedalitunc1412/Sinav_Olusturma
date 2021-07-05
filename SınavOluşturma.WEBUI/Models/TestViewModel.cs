using SınavOluşturma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOluşturma.WEBUI.Models
{
    public class TestViewModel
    {
        public List<Test> TestList { get; set; }

        public List<Question> QuestionList { get; set; }

        public Test Test { get; set; }
    }
}
