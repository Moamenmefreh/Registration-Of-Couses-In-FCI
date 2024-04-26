using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Semster4Configuration : IEntityTypeConfiguration<Semster4>
    {
        public void Configure(EntityTypeBuilder<Semster4> builder)
        {
            builder.HasKey(x => x.CourseCode);
            builder.Property(x => x.CourseCode).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.SemsterId).HasColumnType("int");
            builder.HasOne(e => e.Semster)
                .WithOne(e => e.Semster4).HasForeignKey<Semster4>(
                e => e.SemsterId
                );
            builder.ToTable("Semster4");
        }
        }
    }
