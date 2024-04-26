using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class LevelsConfiguration : IEntityTypeConfiguration<Levels>
    {
        public void Configure(EntityTypeBuilder<Levels> builder)
        {
            builder.HasKey(x=>x.LevelId);
            builder.Property(x=>x.LevelId).ValueGeneratedNever().HasColumnType("int");
            builder.Property(x => x.LevelHoures).HasColumnType("int");
            builder.ToTable("Levels");
        }
    }
}
