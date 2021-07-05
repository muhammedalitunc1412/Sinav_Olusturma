using SınavOluşturma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Services.Abstract
{/// <summary>
/// Bu kısımda gerekli metodları DataAccess'i baz alarak oluşturdum.WEBUI katmanı için
/// Muhammed Ali TUNÇ
/// </summary>
    public interface IUserService
    {
        User GetUserById(int id);

        User GetUser(string userName, string password);
    }
}
