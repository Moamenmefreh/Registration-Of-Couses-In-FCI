using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Level2Configuration : IEntityTypeConfiguration<Level2>
    {
        public void Configure(EntityTypeBuilder<Level2> builder)
        {
            builder.HasKey(x => x.CourseCode2);
            builder.Property(x => x.CourseCode2)
                .ValueGeneratedNever().HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);

            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x => x.SemsterId).HasColumnType("int");
            builder.Property(x => x.Level2Id).HasColumnType("int");

            builder.HasOne(e => e.Courses)
              .WithOne(e => e.Level2)
              .HasForeignKey<Level2>(e => e.CourseCode2);
            builder.ToTable("Level2");
        }
    }
}
