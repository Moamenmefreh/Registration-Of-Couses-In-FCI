using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Level4Configuration : IEntityTypeConfiguration<Level4>
    {
        public void Configure(EntityTypeBuilder<Level4> builder)
        {
            builder.HasKey(x => x.CourseCode4);
            builder.Property(x => x.CourseCode4)
                .ValueGeneratedNever().HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);

            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x => x.SemsterId).HasColumnType("int");
            builder.Property(x => x.Level4Id).HasColumnType("int");
           
            builder.HasOne(e => e.Courses)
               .WithOne(e => e.Level4)
               .HasForeignKey<Level4>(e => e.CourseCode4); 
               
            builder.ToTable("Level4");
        }
    }
}
