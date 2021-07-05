using SınavOluşturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Entities
{/// <summary>
 /// Bu class'ta Test Tablosunu database için oluşturdum
 /// Muhammed Ali TUNÇ
 /// </summary>
    public class Test : EntityBase, IEntityBase
    {
        public int testId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int userId { get; set; }
        public string key { get; set; }

        public DateTime createdDate { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
