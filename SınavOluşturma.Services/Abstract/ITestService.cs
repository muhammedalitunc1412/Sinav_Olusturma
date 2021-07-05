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
    public interface ITestService
    {
        void AddTest(Test test);
        void DeleteTest(Test test);
        Test GetTestWithKey(string key);
        Test GetTestWithId(int id);
        List<Test> GetTestListWithUser(int userId);
        List<Test> GetTestList();
    }
}
