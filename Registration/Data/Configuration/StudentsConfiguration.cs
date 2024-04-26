using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class StudentsConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.HasKey(x => x.StudentId);
            builder.Property(x=>x.StudentId).ValueGeneratedNever();

            builder.Property(x=>x.StudentPassword).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(128);
            builder.Property(x => x.StudentFullName).IsRequired()
                    .HasColumnType("nvarchar").HasMaxLength(250);

            builder.Property(x => x.GPA).HasColumnType("Float");
            builder.Property(x => x.DepartmentCode).
                HasColumnType("nvarchar").HasMaxLength(255);

            builder.Property(x=>x.AllowedHoures).HasColumnType("int").HasMaxLength(10);
            builder.Property(x=>x.LevelId).HasColumnType("int");
            builder.Property(x => x.StudentHours).HasColumnType("int");
            builder.Property(x => x.RegistrationReport).HasColumnType("nvarchar").HasMaxLength(255);

            builder.HasOne(e => e.Levels)
                .WithMany(e => e.Students)
                .HasForeignKey(e => e.LevelId)
                .IsRequired();

           
                builder.HasOne(e=>e.Department)
                .WithMany(e => e.Students)
                .HasForeignKey(e => e.DepartmentCode)
                .IsRequired(false);

            builder.ToTable("Student");

        }
    }
}
