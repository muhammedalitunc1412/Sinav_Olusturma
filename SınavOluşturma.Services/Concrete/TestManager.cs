using SınavOluşturma.Data.Abstract;
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
    public class TestManager : ITestService
    {
        private ITestRepository _testRepository;
        public TestManager(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        public void AddTest(Test test)
        {
            _testRepository.AddTest(test);
        }

        public void DeleteTest(Test test)
        {
            _testRepository.DeleteTest(test);
        }

        public List<Test> GetTestList()
        {
            return _testRepository.GetTestList();
        }

        public List<Test> GetTestListWithUser(int userId)
        {
            return _testRepository.GetTestListWithUser(userId);
        }

        public Test GetTestWithId(int id)
        {
            return _testRepository.GetTestWithId(id);
        }

        public Test GetTestWithKey(string key)
        {
            return _testRepository.GetTestWithKey(key);
        }
    }
}
