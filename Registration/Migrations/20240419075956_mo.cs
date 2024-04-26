using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.Migrations
{
    /// <inheritdoc />
    public partial class mo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminUserName = table.Column<string>(type: "nvarchar", nullable: false),
                    AdminFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminPassword = table.Column<string>(type: "nvarchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminUserName);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentGPA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentCode);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    LevelHoures = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationStudent",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Course1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course6 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course7 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationStudent", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Semster",
                columns: table => new
                {
                    SemsterId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    SemsterHoures = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster", x => x.SemsterId);
                    table.ForeignKey(
                        name: "FK_Semster_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentFullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    StudentPassword = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    StudentHours = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<double>(type: "Float", nullable: false),
                    RegistrationReport = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AllowedHoures = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Department_DepartmentCode",
                        column: x => x.DepartmentCode,
                        principalTable: "Department",
                        principalColumn: "DepartmentCode");
                    table.ForeignKey(
                        name: "FK_Student_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_RegistrationStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "RegistrationStudent",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "Semster1",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster1", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster1_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster2",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster2", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster2_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster3",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster3", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster3_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster4",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster4", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster4_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster5",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster5", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster5_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster6",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster6", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster6_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster7",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster7", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster7_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semster8",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semster8", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Semster8_Semster_SemsterId",
                        column: x => x.SemsterId,
                        principalTable: "Semster",
                        principalColumn: "SemsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    CourseActive = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Courses_Student_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "CoursesDepartment",
                columns: table => new
                {
                    CoursesCourseCode = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DepartmentsDepartmentCode = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesDepartment", x => new { x.CoursesCourseCode, x.DepartmentsDepartmentCode });
                    table.ForeignKey(
                        name: "FK_CoursesDepartment_Courses_CoursesCourseCode",
                        column: x => x.CoursesCourseCode,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesDepartment_Department_DepartmentsDepartmentCode",
                        column: x => x.DepartmentsDepartmentCode,
                        principalTable: "Department",
                        principalColumn: "DepartmentCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Level1",
                columns: table => new
                {
                    CourseCode1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    Level1Id = table.Column<int>(type: "int", nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level1", x => x.CourseCode1);
                    table.ForeignKey(
                        name: "FK_Level1_Courses_CourseCode1",
                        column: x => x.CourseCode1,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Level2",
                columns: table => new
                {
                    CourseCode2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    Level2Id = table.Column<int>(type: "int", nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level2", x => x.CourseCode2);
                    table.ForeignKey(
                        name: "FK_Level2_Courses_CourseCode2",
                        column: x => x.CourseCode2,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Level3",
                columns: table => new
                {
                    CourseCode3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    Level3Id = table.Column<int>(type: "int", nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level3", x => x.CourseCode3);
                    table.ForeignKey(
                        name: "FK_Level3_Courses_CourseCode3",
                        column: x => x.CourseCode3,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Level4",
                columns: table => new
                {
                    CourseCode4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseHoures = table.Column<int>(type: "int", nullable: false),
                    Level4Id = table.Column<int>(type: "int", nullable: false),
                    SemsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level4", x => x.CourseCode4);
                    table.ForeignKey(
                        name: "FK_Level4_Courses_CourseCode4",
                        column: x => x.CourseCode4,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrerRequistes",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseCode1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CourseCode2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CourseCode3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CoursesCourseCode = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrerRequistes", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_PrerRequistes_Courses_CoursesCourseCode",
                        column: x => x.CoursesCourseCode,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentsStudentId",
                table: "Courses",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesDepartment_DepartmentsDepartmentCode",
                table: "CoursesDepartment",
                column: "DepartmentsDepartmentCode");

            migrationBuilder.CreateIndex(
                name: "IX_PrerRequistes_CoursesCourseCode",
                table: "PrerRequistes",
                column: "CoursesCourseCode");

            migrationBuilder.CreateIndex(
                name: "IX_Semster_LevelId",
                table: "Semster",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Semster1_SemsterId",
                table: "Semster1",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster2_SemsterId",
                table: "Semster2",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster3_SemsterId",
                table: "Semster3",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster4_SemsterId",
                table: "Semster4",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster5_SemsterId",
                table: "Semster5",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster6_SemsterId",
                table: "Semster6",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster7_SemsterId",
                table: "Semster7",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semster8_SemsterId",
                table: "Semster8",
                column: "SemsterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_DepartmentCode",
                table: "Student",
                column: "DepartmentCode");

            migrationBuilder.CreateIndex(
                name: "IX_Student_LevelId",
                table: "Student",
                column: "LevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CoursesDepartment");

            migrationBuilder.DropTable(
                name: "Level1");

            migrationBuilder.DropTable(
                name: "Level2");

            migrationBuilder.DropTable(
                name: "Level3");

            migrationBuilder.DropTable(
                name: "Level4");

            migrationBuilder.DropTable(
                name: "PrerRequistes");

            migrationBuilder.DropTable(
                name: "Semster1");

            migrationBuilder.DropTable(
                name: "Semster2");

            migrationBuilder.DropTable(
                name: "Semster3");

            migrationBuilder.DropTable(
                name: "Semster4");

            migrationBuilder.DropTable(
                name: "Semster5");

            migrationBuilder.DropTable(
                name: "Semster6");

            migrationBuilder.DropTable(
                name: "Semster7");

            migrationBuilder.DropTable(
                name: "Semster8");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Semster");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "RegistrationStudent");
        }
    }
}
