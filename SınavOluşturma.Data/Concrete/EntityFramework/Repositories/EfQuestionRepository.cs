using Microsoft.EntityFrameworkCore;
using SınavOluşturma.Data.Abstract;
using SınavOluşturma.Data.Concrete.EntityFramework.Contexts;
using SınavOluşturma.Entities;
using SınavOluşturma.Shared.Data.Concrete.EntityFramework;
using SınavOluşturma.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Concrete.EntityFramework.Repositories
{/// <summary>
/// Bu kısımda gerekli metodları oluşturdum.Business yani Service katmanı için
/// Muhammed Ali TUNÇ
/// </summary>
    public class EfQuestionRepository : IQuestionRepository
    {

        public void AddQuestion(Question question)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                var addedEntity = context.Entry(question);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public List<Question> GetQuestions(int testId, int userId)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                var result = from q in context.Questions
                             join t in context.Tests on q.testId equals t.testId
                             select new Question
                             {
                                 Test = t,
                                 questionId = q.questionId,
                                 selectedFirst = q.selectedFirst,
                                 selectedSecond = q.selectedSecond,
                                 selectedThird = q.selectedThird,
                                 selectedFourth = q.selectedFourth, 
                                 Answer = q.Answer,
                                 testId = q.testId,
                                 question = q.question
                             };

                return result.Where(q => q.testId == testId && q.Test.userId == userId).ToList();

            }
        }

        public List<Question> GetTestQuestion(int testId)
        {
            using (SınavOluşturContext context = new SınavOluşturContext())
            {
                return context.Questions.Where(q => q.testId == testId).ToList();
            }
        }
    }
}