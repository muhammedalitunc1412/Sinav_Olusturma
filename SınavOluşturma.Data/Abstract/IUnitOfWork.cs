using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Abstract
{/// <summary>
/// Bu kısımda hepsini tek bir ortak noktada toplayabilmek için bir yapı kurmuştum fakat.Kod yapımı daha iyi anlayın diye oluşturmadım
/// Muhammed Ali TUNÇ
/// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {

        IQuestionRepository Questions { get; }
        ITestRepository Tests { get; }
        IUserRepository Users { get; } 
        Task<int> SaveAsync();

    }
}
