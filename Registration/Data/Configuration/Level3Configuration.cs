using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Level3Configuration : IEntityTypeConfiguration<Level3>
    {
        public void Configure(EntityTypeBuilder<Level3> builder)
        {
            builder.HasKey(x => x.CourseCode3);
            builder.Property(x => x.CourseCode3)
                .ValueGeneratedNever().HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);

            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x => x.SemsterId).HasColumnType("int");
            builder.Property(x => x.Level3Id).HasColumnType("int");
           
            builder.HasOne(e => e.Courses)
               .WithOne(e => e.Level3)
               .HasForeignKey<Level3>(e => e.CourseCode3); 
            builder.ToTable("Level3");
        }
    }
}
