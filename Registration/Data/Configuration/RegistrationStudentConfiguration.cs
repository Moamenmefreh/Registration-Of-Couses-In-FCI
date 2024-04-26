using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class RegistrationStudentConfiguration : IEntityTypeConfiguration<RegistrationStudent>
    {
        public void Configure(EntityTypeBuilder<RegistrationStudent> builder)
        {
            builder.HasKey(x => x.StudentId);
            builder.Property(x=>x.StudentId).ValueGeneratedNever();

            builder.Property(x => x.Course1).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course2).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course3).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course4).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course5).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course6).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course7).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Course8).HasColumnType("nvarchar").HasMaxLength(255);
            builder.HasMany(e => e.students)
                .WithOne(e => e.RegistrationStudent)
                .HasForeignKey(e => e.StudentId)
                .IsRequired(false);
            builder.ToTable("RegistrationStudent");
        }
    }
}
