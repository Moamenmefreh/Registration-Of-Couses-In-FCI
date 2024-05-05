using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class ActiveCoursesConfiguration : IEntityTypeConfiguration<ActiveCourses>
    {
        public void Configure(EntityTypeBuilder<ActiveCourses> builder)
        {
            builder.HasKey(x=>x.CourseCode);
            builder.Property(x => x.CourseCode).ValueGeneratedNever().HasMaxLength(255);
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseHours).HasColumnType("int").IsRequired();

            builder.HasOne(x => x.courses).WithOne(x => x.ActiveCourses)
                .HasForeignKey<ActiveCourses>(e => e.CourseCode);
        }
    }
}
