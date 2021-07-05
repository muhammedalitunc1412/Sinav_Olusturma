using SınavOluşturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntityBase, new()
    {
        ///.summary
        /// Burda kodların genel update addd delete select gibi işlemlerini yapabiliriz fakat proje küçük olduğu için kendim yazdım
        /// Muhammed Ali TUNÇ

      
    }
}
