using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Level1Configuration : IEntityTypeConfiguration<Level1>
    {
        public void Configure(EntityTypeBuilder<Level1> builder)
        {
            builder.HasKey(x => x.CourseCode1);
            builder.Property(x => x.CourseCode1)
                .ValueGeneratedNever().HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);

            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x=>x.SemsterId).HasColumnType("int");
            builder.Property(x=>x.Level1Id).HasColumnType("int");
           
            builder.HasOne(e => e.Courses)
              .WithOne(e => e.Level1)
              .HasForeignKey<Level1>(e=>e.CourseCode1);
            builder.ToTable("Level1");
        }
    }
}
