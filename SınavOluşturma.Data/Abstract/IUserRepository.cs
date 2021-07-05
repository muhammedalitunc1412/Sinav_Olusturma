using SınavOluşturma.Entities;
using SınavOluşturma.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Abstract
{/// <summary>
/// Bu kısımda interface class ile kullanılacak metodları belirttim.Controller Kısmından çekebilmek için
/// Muhammed Ali TUNÇ
/// </summary>
    public interface IUserRepository:IEntityRepository<User>
    {
        User GetUserById(int id);

        User GetUser(string userName, string password);

    }
}
