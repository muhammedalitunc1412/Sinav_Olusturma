using SınavOluşturma.Data.Abstract;
using SınavOluşturma.Data.Concrete.EntityFramework.Contexts;
using SınavOluşturma.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Concrete
{
    public class UnitOfWork 
    {
        private readonly SınavOluşturContext _context;
        private EfTestRepository _testRepository;
        private EfQuestionRepository _questionRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(SınavOluşturContext context)
        {
            _context = context;
        }


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
