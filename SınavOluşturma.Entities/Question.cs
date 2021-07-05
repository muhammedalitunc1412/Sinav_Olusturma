using SınavOluşturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Entities
{/// <summary>
/// Bu class'ta Question Tablosunu database için oluşturdum
/// Muhammed Ali TUNÇ
/// </summary>
   public class Question:EntityBase,IEntityBase
    {
        public int questionId { get; set; }
        public int testId { get; set; }
        public string question { get; set; }
        public string selectedFirst { get; set; }
        public string selectedSecond { get; set; }
        public string selectedThird { get; set; }
        public string selectedFourth { get; set; }
        public string Answer { get; set; }

        public Test Test { get; set; }
    }
}
