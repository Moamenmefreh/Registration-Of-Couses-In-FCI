﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registration.Data;

#nullable disable

namespace Registration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240419075956_mo")]
    partial class mo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoursesDepartment", b =>
                {
                    b.Property<string>("CoursesCourseCode")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DepartmentsDepartmentCode")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CoursesCourseCode", "DepartmentsDepartmentCode");

                    b.HasIndex("DepartmentsDepartmentCode");

                    b.ToTable("CoursesDepartment");
                });

            modelBuilder.Entity("Registration.Models.Admins", b =>
                {
                    b.Property<string>("AdminUserName")
                        .HasColumnType("nvarchar");

                    b.Property<string>("AdminFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.HasKey("AdminUserName");

                    b.ToTable("Admins", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Courses", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CourseActive")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("DepartmentCode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.Property<string>("StudentsStudentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseCode");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Department", b =>
                {
                    b.Property<string>("DepartmentCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("DepartmentGPA")
                        .HasColumnType("float");

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.HasKey("DepartmentCode");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Level1", b =>
                {
                    b.Property<string>("CourseCode1")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<int>("Level1Id")
                        .HasColumnType("int");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode1");

                    b.ToTable("Level1", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Level2", b =>
                {
                    b.Property<string>("CourseCode2")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<int>("Level2Id")
                        .HasColumnType("int");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode2");

                    b.ToTable("Level2", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Level3", b =>
                {
                    b.Property<string>("CourseCode3")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<int>("Level3Id")
                        .HasColumnType("int");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode3");

                    b.ToTable("Level3", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Level4", b =>
                {
                    b.Property<string>("CourseCode4")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<int>("Level4Id")
                        .HasColumnType("int");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode4");

                    b.ToTable("Level4", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Levels", b =>
                {
                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("LevelHoures")
                        .HasColumnType("int");

                    b.HasKey("LevelId");

                    b.ToTable("Levels", (string)null);
                });

            modelBuilder.Entity("Registration.Models.PreRequistes", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CourseCode1")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CourseCode2")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CourseCode3")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CoursesCourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CourseCode");

                    b.HasIndex("CoursesCourseCode");

                    b.ToTable("PrerRequistes", (string)null);
                });

            modelBuilder.Entity("Registration.Models.RegistrationStudent", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Course1")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course2")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course3")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course4")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course5")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course6")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course7")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Course8")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.HasKey("StudentId");

                    b.ToTable("RegistrationStudent", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster", b =>
                {
                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("SemsterHoures")
                        .HasColumnType("int");

                    b.HasKey("SemsterId");

                    b.HasIndex("LevelId");

                    b.ToTable("Semster", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster1", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster1", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster2", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster2", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster3", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster3", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster4", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster4", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster5", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster5", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster6", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster6", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster7", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster7", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Semster8", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("CourseHoures")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("SemsterId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("SemsterId")
                        .IsUnique();

                    b.ToTable("Semster8", (string)null);
                });

            modelBuilder.Entity("Registration.Models.Students", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AllowedHoures")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("DepartmentCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<double>("GPA")
                        .HasColumnType("Float");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationReport")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("StudentFullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.Property<int>("StudentHours")
                        .HasColumnType("int");

                    b.Property<string>("StudentPassword")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentCode");

                    b.HasIndex("LevelId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("CoursesDepartment", b =>
                {
                    b.HasOne("Registration.Models.Courses", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Registration.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Registration.Models.Courses", b =>
                {
                    b.HasOne("Registration.Models.Students", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentsStudentId");
                });

            modelBuilder.Entity("Registration.Models.Level1", b =>
                {
                    b.HasOne("Registration.Models.Courses", "Courses")
                        .WithOne("Level1")
                        .HasForeignKey("Registration.Models.Level1", "CourseCode1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Registration.Models.Level2", b =>
                {
                    b.HasOne("Registration.Models.Courses", "Courses")
                        .WithOne("Level2")
                        .HasForeignKey("Registration.Models.Level2", "CourseCode2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Registration.Models.Level3", b =>
                {
                    b.HasOne("Registration.Models.Courses", "Courses")
                        .WithOne("Level3")
                        .HasForeignKey("Registration.Models.Level3", "CourseCode3")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Registration.Models.Level4", b =>
                {
                    b.HasOne("Registration.Models.Courses", "Courses")
                        .WithOne("Level4")
                        .HasForeignKey("Registration.Models.Level4", "CourseCode4")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Registration.Models.PreRequistes", b =>
                {
                    b.HasOne("Registration.Models.Courses", "Courses")
                        .WithMany("PreRequistes")
                        .HasForeignKey("CoursesCourseCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Registration.Models.Semster", b =>
                {
                    b.HasOne("Registration.Models.Levels", "Levels")
                        .WithMany("Semsters")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Levels");
                });

            modelBuilder.Entity("Registration.Models.Semster1", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster1")
                        .HasForeignKey("Registration.Models.Semster1", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster2", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster2")
                        .HasForeignKey("Registration.Models.Semster2", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster3", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster3")
                        .HasForeignKey("Registration.Models.Semster3", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster4", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster4")
                        .HasForeignKey("Registration.Models.Semster4", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster5", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster5")
                        .HasForeignKey("Registration.Models.Semster5", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster6", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster6")
                        .HasForeignKey("Registration.Models.Semster6", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster7", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster7")
                        .HasForeignKey("Registration.Models.Semster7", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Semster8", b =>
                {
                    b.HasOne("Registration.Models.Semster", "Semster")
                        .WithOne("Semster8")
                        .HasForeignKey("Registration.Models.Semster8", "SemsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semster");
                });

            modelBuilder.Entity("Registration.Models.Students", b =>
                {
                    b.HasOne("Registration.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentCode");

                    b.HasOne("Registration.Models.Levels", "Levels")
                        .WithMany("Students")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Registration.Models.RegistrationStudent", "RegistrationStudent")
                        .WithMany("students")
                        .HasForeignKey("StudentId");

                    b.Navigation("Department");

                    b.Navigation("Levels");

                    b.Navigation("RegistrationStudent");
                });

            modelBuilder.Entity("Registration.Models.Courses", b =>
                {
                    b.Navigation("Level1")
                        .IsRequired();

                    b.Navigation("Level2")
                        .IsRequired();

                    b.Navigation("Level3")
                        .IsRequired();

                    b.Navigation("Level4")
                        .IsRequired();

                    b.Navigation("PreRequistes");
                });

            modelBuilder.Entity("Registration.Models.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Registration.Models.Levels", b =>
                {
                    b.Navigation("Semsters");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Registration.Models.RegistrationStudent", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("Registration.Models.Semster", b =>
                {
                    b.Navigation("Semster1")
                        .IsRequired();

                    b.Navigation("Semster2")
                        .IsRequired();

                    b.Navigation("Semster3")
                        .IsRequired();

                    b.Navigation("Semster4")
                        .IsRequired();

                    b.Navigation("Semster5")
                        .IsRequired();

                    b.Navigation("Semster6")
                        .IsRequired();

                    b.Navigation("Semster7")
                        .IsRequired();

                    b.Navigation("Semster8")
                        .IsRequired();
                });

            modelBuilder.Entity("Registration.Models.Students", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}