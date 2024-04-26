using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class PrereRequistes : IEntityTypeConfiguration<PreRequistes>
    {
        
        public void Configure(EntityTypeBuilder<PreRequistes> builder)
        {
            builder.HasKey(x => x.CourseCode);
            builder.Property(x => x.CourseCode).HasMaxLength(255);
            builder.Property(x => x.CourseCode1).ValueGeneratedNever().HasMaxLength(255);
            builder.Property(x => x.CourseCode1).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseCode2).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseCode3).HasColumnType("nvarchar").HasMaxLength(255);
           

            builder.ToTable("PrerRequistes");
        }
    }
}
