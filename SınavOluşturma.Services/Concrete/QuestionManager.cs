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
    public class QuestionManager:IQuestionService
    {   
        private IQuestionRepository _questionRepository;
        public QuestionManager(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public void AddQuestion(Question question)
        {
            _questionRepository.AddQuestion(question);
        }

        public List<Question> GetQuestions(int testId, int userId)
        {
            return _questionRepository.GetQuestions(testId,userId);
        }

        public List<Question> GetTestQuestion(int testId)
        {
            return _questionRepository.GetTestQuestion(testId);
        }

        public void SaveQuestions(Question[] questions, Test test)
        {
            foreach (Question question in questions)
            {
                question.testId = test.testId;
                AddQuestion(question);
            }
        }
    }
}
