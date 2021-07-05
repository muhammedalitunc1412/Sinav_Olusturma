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
    public interface ITestRepository : IEntityRepository<Test>
    {
        void AddTest(Test test);
        void DeleteTest(Test test);
        Test GetTestWithKey(string key);
        Test GetTestWithId(int id);
        List<Test> GetTestListWithUser(int userId);
        List<Test> GetTestList();



    }
}
