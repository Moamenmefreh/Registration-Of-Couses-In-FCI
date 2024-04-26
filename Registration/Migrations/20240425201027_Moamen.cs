using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.Migrations
{
    /// <inheritdoc />
    public partial class Moamen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrerRequistes_Courses_CoursesCourseCode",
                table: "PrerRequistes");

            migrationBuilder.DropIndex(
                name: "IX_PrerRequistes_CoursesCourseCode",
                table: "PrerRequistes");

            migrationBuilder.DropColumn(
                name: "CoursesCourseCode",
                table: "PrerRequistes");

            migrationBuilder.AddForeignKey(
                name: "FK_PrerRequistes_Courses_CourseCode",
                table: "PrerRequistes",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrerRequistes_Courses_CourseCode",
                table: "PrerRequistes");

            migrationBuilder.AddColumn<string>(
                name: "CoursesCourseCode",
                table: "PrerRequistes",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PrerRequistes_CoursesCourseCode",
                table: "PrerRequistes",
                column: "CoursesCourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PrerRequistes_Courses_CoursesCourseCode",
                table: "PrerRequistes",
                column: "CoursesCourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
