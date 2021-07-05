using Microsoft.Extensions.DependencyInjection;
using SınavOluşturma.Data.Abstract;
using SınavOluşturma.Data.Concrete;
using SınavOluşturma.Data.Concrete.EntityFramework.Contexts;
using SınavOluşturma.Services.Abstract;
using SınavOluşturma.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {/// <summary>
    /// Bu kısımda hangi abstract class'ın hangi concrete class'ın metodlarını aldığını belirtiyordum fakat.Startup class'ında belirttim
    /// Muhammed Ali TUNÇ
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <returns></returns>
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<SınavOluşturContext>();      
            return serviceCollection;
        }
    }
}
