using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class CoursesCpnfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.HasKey(x=>x.CourseCode);
            builder.Property(x => x.CourseCode).ValueGeneratedNever().HasMaxLength(255);

            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);
            
            builder.Property(x => x.CourseActive).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.DepartmentCode).HasColumnType("nvarchar").HasMaxLength(255);

            builder.Property(x => x.CourseHoures).HasColumnType("int").IsRequired();
            builder.Property(x=>x.SemsterId).HasColumnType("int").IsRequired();

            builder.HasMany(e => e.Departments)
                 .WithMany(e => e.Courses);

            builder.HasOne(e => e.PreRequistes)
               .WithOne(e => e.Courses).HasForeignKey<PreRequistes>(x=>x.CourseCode);

            builder.ToTable("Courses");



        }
    }
}
