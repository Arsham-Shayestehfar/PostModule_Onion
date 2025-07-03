using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.CityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(x => x.Id);

            builder.Property(c=>c.Title).IsRequired(true).HasMaxLength(150);
            builder.Property(c => c.Status).IsRequired(true).HasMaxLength(150);
            builder.Property(c => c.StateId).IsRequired(true);
           
            builder.Property(c => c.CreateDate).IsRequired(true);

            builder.HasOne(c=>c.State).WithMany(c=>c.Cities).HasForeignKey(c=>c.StateId);
        }
    }
}
