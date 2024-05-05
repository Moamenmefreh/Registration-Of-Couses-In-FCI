using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Data;
using Registration.Dto;
using Registration.Models;
using System.Linq;

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

       
        [HttpPost("Register For Student")]

        public async Task<IActionResult> Registration([FromForm] DtoRegistrationStudent dtoRegistrationStudent)
        {

           
            var CourseCodePre = await dbcontext.PreRequistes.SingleOrDefaultAsync(x => x.CourseCode == dtoRegistrationStudent.CourseCode);
            var StudentRegistration = await dbcontext.RegistrationStudent.SingleOrDefaultAsync(x => x.StudentId == dtoRegistrationStudent.StudentID);

          var course=await dbcontext.Courses.SingleOrDefaultAsync(x=>x.CourseCode== dtoRegistrationStudent.CourseCode);
           
            
            var student = await dbcontext.student
                      .SingleOrDefaultAsync(x => x.StudentId == dtoRegistrationStudent.StudentID);
            
            
            
            if (CourseCodePre.CourseCode1 == null &&
            CourseCodePre.CourseCode2 == null
            && CourseCodePre.CourseCode3 == null
            &&StudentRegistration.StudentId==dtoRegistrationStudent.StudentID            
            )
                {
               

                if (StudentRegistration.Course1 == null)
                    {
                   
                    if (StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                        StudentRegistration.Course1 = dtoRegistrationStudent.CourseCode;
                        StudentRegistration.RecordedHours += course.CourseHoures;
                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();


                        return Ok(StudentRegistration);
                    }
                    else
                    {
                        return BadRequest("Sorry You Completed The Hours Allowed You");
                    }
                    }

                    else if (StudentRegistration.Course2 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                   
                        StudentRegistration.Course2 = dtoRegistrationStudent.CourseCode;
                        StudentRegistration.RecordedHours += course.CourseHoures;
                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();



                        return Ok(StudentRegistration);
                   
                }
                    else if (StudentRegistration.Course3 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                   
                        StudentRegistration.Course3 = dtoRegistrationStudent.CourseCode;
                        StudentRegistration.RecordedHours += course.CourseHoures;
                        dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();



                        return Ok(StudentRegistration);
                    }
                   
                    else if (StudentRegistration.Course4 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                    
                        StudentRegistration.Course4 = dtoRegistrationStudent.CourseCode;
                    StudentRegistration.RecordedHours += course.CourseHoures;
                    dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();



                        return Ok(StudentRegistration);
                    }
                    
                    else if (StudentRegistration.Course5 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {

                   
                        StudentRegistration.Course5 = dtoRegistrationStudent.CourseCode;
                    StudentRegistration.RecordedHours += course.CourseHoures;
                    dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();


                        return Ok(StudentRegistration);
                    }
                    
                    else if (StudentRegistration.Course6 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                   
                        StudentRegistration.Course6 = dtoRegistrationStudent.CourseCode;
                    StudentRegistration.RecordedHours += course.CourseHoures;

                    dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();



                        return Ok(StudentRegistration);
                    }
                    
                    else if (StudentRegistration.Course7 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                    
                        StudentRegistration.Course7 = dtoRegistrationStudent.CourseCode;
                    StudentRegistration.RecordedHours += course.CourseHoures;

                    dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();

                           return Ok(StudentRegistration);
                    }
                   
                    else if (StudentRegistration.Course8 == null && StudentRegistration.RecordedHours < student.AllowedHoures)
                    {
                   
                        StudentRegistration.Course8 = dtoRegistrationStudent.CourseCode;
                    StudentRegistration.RecordedHours += course.CourseHoures;

                    dbcontext.RegistrationStudent.Update(StudentRegistration);
                        dbcontext.SaveChanges();



                        return Ok(StudentRegistration);
                    }
                    

                    else
                    {

                        return BadRequest("You Have Completed The number Of Registration Hours");
                    }


                }
                else
                {
                    return BadRequest("Sorry May By ID Not Found Or  $\"Sorry This Course Has PreRequistes " +
                        "{CourseCodePre.CourseCode1} ??  {CourseCodePre.CourseCode2} ??  {CourseCodePre.CourseCode3}\"");
                }

            }




        [HttpPut("Delete Course From Register For Student")]

        public async Task<IActionResult> DeleteCourse([FromForm] DtoRegistrationStudent dtoRegistrationStudent)
        {


            var StudentRegistration = await dbcontext.RegistrationStudent.SingleOrDefaultAsync(x => x.StudentId == dtoRegistrationStudent.StudentID);

            var course = await dbcontext.Courses.SingleOrDefaultAsync(x => x.CourseCode == dtoRegistrationStudent.CourseCode);


            var student = await dbcontext.student
                      .SingleOrDefaultAsync(x => x.StudentId == dtoRegistrationStudent.StudentID);



           


                if (StudentRegistration.Course1 == dtoRegistrationStudent.CourseCode
                &&StudentRegistration.StudentId==dtoRegistrationStudent.StudentID)
                {

                StudentRegistration.Course1 = null;
                
                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration);
                dbcontext.SaveChanges();


                        return Ok("Course Deleted From Registration Successfully");
                   
                }

                else if (StudentRegistration.Course2 == dtoRegistrationStudent.CourseCode )
                {


                StudentRegistration.Course2 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration);
                dbcontext.SaveChanges();


                return Ok("Course Deleted From Registration Successfully");

            }
                else if (StudentRegistration.Course3 == dtoRegistrationStudent.CourseCode)
                {


                StudentRegistration.Course3 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration);
                dbcontext.SaveChanges();


                return Ok("Course Deleted From Registration Successfully");
            }

                else if (StudentRegistration.Course4 == dtoRegistrationStudent.CourseCode)
                {


                StudentRegistration.Course4 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration);
                dbcontext.SaveChanges();


                return Ok(StudentRegistration);
            }

                else if (StudentRegistration.Course5 == dtoRegistrationStudent.CourseCode)
                {


                StudentRegistration.Course5 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration); dbcontext.SaveChanges();


                return Ok("Course Deleted From Registration Successfully");
            }

                else if (StudentRegistration.Course6 == dtoRegistrationStudent.CourseCode)
                {

                StudentRegistration.Course6 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration); dbcontext.SaveChanges();


                return Ok("Course Deleted From Registration Successfully");
            }

                else if (StudentRegistration.Course7 == dtoRegistrationStudent.CourseCode)
                {

                StudentRegistration.Course7 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration); dbcontext.SaveChanges();


                return Ok("Course Deleted From Registration Successfully");
            }

                else if (StudentRegistration.Course8 == dtoRegistrationStudent.CourseCode)
                {

                StudentRegistration.Course8 = null;

                StudentRegistration.RecordedHours -= course.CourseHoures;
                dbcontext.RegistrationStudent.Update(StudentRegistration); dbcontext.SaveChanges();


                return Ok("Course Deleted From Registration Successfully");
            }


                else
                {

                    return BadRequest("Sorry This Course Not Found In Registration Student Table");
                }


            }


        [HttpGet("Return All Courses Registration By Student")]
           public async Task<IActionResult> GetAllCoursesRegistration(string ID)
        {
            var Student = await dbcontext.RegistrationStudent
                
                .Where(x => x.StudentId == ID).ToListAsync();
           
            return Ok(Student);
        }
       }          
               

            }




