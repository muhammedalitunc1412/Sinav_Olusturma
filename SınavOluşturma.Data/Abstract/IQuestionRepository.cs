using SınavOluşturma.Entities;
using SınavOluşturma.Shared.Data.Abstract;
using SınavOluşturma.Shared.Utilities.Results.Abstract;
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
   public interface IQuestionRepository : IEntityRepository<Question>
    {
        void AddQuestion(Question question);
        List<Question> GetQuestions(int testId,int userId);
        List<Question> GetTestQuestion(int testId);
      
    }
}
