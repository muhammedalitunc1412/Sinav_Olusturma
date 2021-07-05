using SınavOluşturma.Entities;
using SınavOluşturma.Shared.Utilities.Results.Abstract;
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
    public interface IQuestionService
    {
        void AddQuestion(Question question);
        List<Question> GetQuestions(int testId, int userId);
        List<Question> GetTestQuestion(int testId);
        void SaveQuestions(Question[] questions, Test test);

    }
}
