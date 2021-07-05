using SınavOluşturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Entities
{/// <summary>
/// Bu class'ta User Tablosunu database için oluşturdum
/// Muhammed Ali TUNÇ
/// </summary>
    public class User : EntityBase, IEntityBase
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
}
