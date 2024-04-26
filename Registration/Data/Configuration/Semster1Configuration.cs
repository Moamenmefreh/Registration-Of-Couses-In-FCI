using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Semster1Configuration : IEntityTypeConfiguration<Semster1>
    {
        public void Configure(EntityTypeBuilder<Semster1> builder)
        {
            builder.HasKey(x => x.CourseCode);
            builder.Property(x => x.CourseCode).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x=>x.SemsterId).HasColumnType("int");
            builder.HasOne(e => e.Semster)
                .WithOne(e => e.Semster1).HasForeignKey<Semster1>(
                e => e.SemsterId
                );
            builder.ToTable("Semster1");
        }
    }
}
