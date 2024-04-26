using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class SemsterConfiguration : IEntityTypeConfiguration<Semster>
    {
        public void Configure(EntityTypeBuilder<Semster> builder)
        {
            builder.HasKey(x => x.SemsterId);
            builder.Property(x=>x.SemsterId).ValueGeneratedNever();
            builder.Property(x=>x.LevelId).HasColumnType("int");
            builder.Property(x=>x.SemsterHoures).HasColumnType("int");
            builder.HasOne(x => x.Levels)
                   .WithMany(x => x.Semsters)
                   .HasForeignKey(x => x.LevelId);
            builder.ToTable("Semster");
        }
    }
}
