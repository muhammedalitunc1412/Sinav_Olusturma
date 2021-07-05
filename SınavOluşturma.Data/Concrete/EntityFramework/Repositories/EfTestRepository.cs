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
    public class EfTestRepository :  ITestRepository
    {
       

        public void AddTest(Test test)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                var addedEntity = context.Entry(test);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteTest(Test test)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                var deletedEntity = context.Entry(test);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Test> GetTestList()
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                return context.Tests.ToList();
            }
        }

        public List<Test> GetTestListWithUser(int userId)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                return context.Tests.Where(t => t.userId == userId).ToList();
            }
        }

        public Test GetTestWithId(int id)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                return context.Tests.Where(t => t.testId == id).FirstOrDefault();
            }
        }

        public Test GetTestWithKey(string key)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                return context.Tests.Where(t => t.key == key).FirstOrDefault();
            }
        }
    }
}
