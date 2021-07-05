using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SınavOluşturma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Data.Concrete.EntityFramework.Mappings
{/// <summary>
/// Bu kısımda gerekli tablonun gerekli verilerini eklettim.SeedDatabase gibi
/// Muhammed Ali TUNÇ
/// </summary>
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.userId);
            builder.Property(a => a.userId).ValueGeneratedOnAdd();
            builder.Property(a => a.userId).ValueGeneratedNever();
            builder.Property(a => a.userName).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.userPassword).IsRequired(true);

            builder.HasData(new User
            {
                userId = 1,
                userName = "muhammedalitunc",
                userPassword = "muhammedalitunc",
                IsDeleted=false,
                
            });;


        }
    }
}
