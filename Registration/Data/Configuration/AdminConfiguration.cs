using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admins>
    {
        public void Configure(EntityTypeBuilder<Admins> builder)
        {
            builder.HasKey(x => x.AdminUserName);
            builder.Property(x=>x.AdminUserName).ValueGeneratedNever().HasMaxLength(255);
            builder.Property(x=> x.AdminPassword).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.AdminUserName).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(255);
            builder.ToTable("Admins");
        }
    }
}
