using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {/// <summary>
    /// Bu kısımda projemizdeki tüm veritabanı tablolarının ortak kullanabileceği kısmı oluşturdum
    /// Muhammed Ali TUNÇ
    /// </summary>
        public virtual bool IsDeleted { get; set; } = false;
    }
}
