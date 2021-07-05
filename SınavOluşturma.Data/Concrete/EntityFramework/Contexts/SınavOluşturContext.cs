using Microsoft.EntityFrameworkCore;
using SınavOluşturma.Data.Concrete.EntityFramework.Mappings;
using SınavOluşturma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Concrete.EntityFramework.Contexts
{/// <summary>
/// Bu kısımda veritabanını ve Mapping içinde ki verilerin oluşumunu gerçekleştirdim.
/// Muhammed Ali TUNÇ
/// </summary>
    public class SınavOluşturContext:DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-V2QVTM5;Database=SınavOluştur;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestMap());
            modelBuilder.ApplyConfiguration(new QuestionMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
