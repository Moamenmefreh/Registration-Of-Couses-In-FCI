﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.Data.Configuration
{
    public class Semster8Configuration : IEntityTypeConfiguration<Semster8>
    {
        public void Configure(EntityTypeBuilder<Semster8> builder)
        {


            builder.HasKey(x => x.CourseCode);
            builder.Property(x => x.CourseCode).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.CourseHoures).HasColumnType("int");
            builder.Property(x => x.CourseName).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.SemsterId).HasColumnType("int");
            builder.HasOne(e => e.Semster)
                .WithOne(e => e.Semster8).HasForeignKey<Semster8>(
                e => e.SemsterId
                );
            builder.ToTable("Semster8");
        }
        }
    }
