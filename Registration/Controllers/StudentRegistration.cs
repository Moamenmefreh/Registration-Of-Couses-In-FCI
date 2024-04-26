using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Data;
using Registration.Models;

namespace Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistration : ControllerBase
    {
        private readonly AppDbContext dbcontext;



        public StudentRegistration(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        Int128 AllowedHoures = 0;
        [HttpPost("Register For Student")]

        public async Task<IActionResult> Registration([FromForm] string CoursCode, string ID)
        {
            var CourseCodePre = await dbcontext.PreRequistes.SingleOrDefaultAsync(x => x.CourseCode == CoursCode);
            var StudentRegistration = await dbcontext.RegistrationStudent.SingleOrDefaultAsync(x => x.StudentId == ID);
            var CourseFromCourses = await dbcontext.Courses.SingleOrDefaultAsync(
                x => x.CourseCode == CoursCode
                );
            if (CourseFromCourses == null)
            {
                return BadRequest("Sorry Course is not found ");
            }
            else
            {
                var CourseFromCoursesToReg = new Courses()
                {
                    CourseCode = CourseFromCourses.CourseCode
                };

                var Student = await dbcontext.student.SingleOrDefaultAsync(x => x.StudentId == ID);


                if (CourseCodePre.CourseCode1 == null &&
                    CourseCodePre.CourseCode2 == null
                    && CourseCodePre.CourseCode3 == null && AllowedHoures < Student.AllowedHoures)
                {
                    if (StudentRegistration.Course1 == null)
                    {

                        StudentRegistration.Course1 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();


                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }

                    else if (StudentRegistration.Course2 == null)
                    {

                        StudentRegistration.Course2 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else if (StudentRegistration.Course3 == null)
                    {

                        StudentRegistration.Course3 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else if (StudentRegistration.Course4 == null)
                    {

                        StudentRegistration.Course4 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else if (StudentRegistration.Course5 == null)
                    {

                        StudentRegistration.Course5 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else if (StudentRegistration.Course6 == null)
                    {

                        StudentRegistration.Course6 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else if (StudentRegistration.Course7 == null)
                    {

                        StudentRegistration.Course7 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else if (StudentRegistration.Course8 == null)
                    {

                        StudentRegistration.Course8 = CoursCode;

                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();
                        AllowedHoures += CourseFromCourses.CourseHoures;

                        AllowedHoures += CourseFromCourses.CourseHoures;

                        return Ok(StudentRegistration);
                    }
                    else
                    {
                        return BadRequest("Sorry The AllowedHoures IS Completed");
                    }
                }
                else
                {
                    return BadRequest($"Sorry This Course Has PreRequistes {CourseCodePre.CourseCode1} ??  {CourseCodePre.CourseCode2} ??  {CourseCodePre.CourseCode3}");
                }
            }
        }
    }
}