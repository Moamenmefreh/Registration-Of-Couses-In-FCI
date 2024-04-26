using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x=>x.DepartmentCode);
            builder.Property(x=>x.DepartmentCode).ValueGeneratedNever().HasMaxLength(255);
            builder.Property(x => x.DepartmentName).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.DepartmentGPA).HasColumnType("float");
            builder.ToTable("Department");
        }
    }
}
