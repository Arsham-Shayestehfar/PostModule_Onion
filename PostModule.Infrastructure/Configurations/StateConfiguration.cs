using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.Configurations
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("States");
            builder.HasKey(x => x.Id);

            builder.Property(s => s.Title).IsRequired(true).HasMaxLength(150);
            builder.Property(s => s.CloseStates).IsRequired(false).HasMaxLength(90);
            builder.Property(s => s.Title).IsRequired(true);

            builder.HasMany(s=> s.Cities).WithOne(s=>s.State).HasForeignKey(s=>s.StateId);
        }
    }
}
