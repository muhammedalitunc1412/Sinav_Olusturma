using SınavOluşturma.Data.Abstract;
using SınavOluşturma.Data.Concrete.EntityFramework.Contexts;
using SınavOluşturma.Entities;
using SınavOluşturma.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Services.Concrete
{/// <summary>
/// Bu kısımda gerekli metodları işlevsel hale getirdim.WEBUI katmanı için
/// Muhammed Ali TUNÇ
/// </summary>
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetUser(string userName, string password)
        {
            return _userRepository.GetUser(userName, password);
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
