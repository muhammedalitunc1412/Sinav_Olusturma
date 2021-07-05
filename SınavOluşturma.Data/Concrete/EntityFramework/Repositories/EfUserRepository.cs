using Microsoft.EntityFrameworkCore;
using SınavOluşturma.Data.Abstract;
using SınavOluşturma.Data.Concrete.EntityFramework.Contexts;
using SınavOluşturma.Entities;
using SınavOluşturma.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Concrete.EntityFramework.Repositories
{/// <summary>
/// Bu kısımda gerekli metodları oluşturdum.Business yani Service katmanı için
/// Muhammed Ali TUNÇ
/// </summary>
    public class EfUserRepository : IUserRepository
    {
        public User GetUser(string userName, string password)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                User user = context.Users.Where(user => user.userName == userName && user.userPassword == password).FirstOrDefault();
                return user;

            }
        }

        public User GetUserById(int id)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                User user = context.Users.Where(user => user.userId == id).FirstOrDefault();
                return user;

            }
        }
    }
}
