using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Registration.Data;

using Registration.Models;
using RegistrationSystem.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Controllers
{
    [Authorize(Roles ="Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class Administratorpowers : ControllerBase
    {
        private readonly AppDbContext dbcontext;

        public Administratorpowers(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpGet("GetReportForStudentBy Id")]
        public async Task<IActionResult> GetReportForStudent(string Id)
        {
            var getstudent = await dbcontext.student.Where(x => x.StudentId == Id).Select(x => new dtoReport
            {
                StudentId = x.StudentId,
                StudentPasswor = x.StudentPassword,
                StudentName = x.StudentFullName,
                Student_GPA = x.GPA
            }).ToListAsync();
            if (getstudent == null)
            {

                return NotFound("Not Found In Database");
            }
            else

                return Ok(getstudent);

        }
        [HttpDelete("Delete Courses")]
        public async Task<IActionResult> DeleteCourses(string Courses_Code)
        {
            var deletecourses = await dbcontext.Courses.SingleOrDefaultAsync(x => x.CourseCode == Courses_Code);
            if (deletecourses == null)
            {
                return NotFound("THis Course Not Found In Database");
            }
            else
            {
                dbcontext.Remove(deletecourses);

                return Ok(deletecourses);
            }
        }

        [HttpPost("AddCourse")]
        public async Task<IActionResult> AddCourses([FromForm] dtoAddDourse dtoAddd)
        {

            var course = await dbcontext.Courses.SingleOrDefaultAsync(x => x.CourseCode == dtoAddd.Course_Code);

            var addCourses = new Courses
            {
                CourseCode = dtoAddd.Course_Code,
                CourseName = dtoAddd.Course_Name,
                CourseActive = dtoAddd.Course_Active,
                CourseHoures = dtoAddd.Course_Hours,
                DepartmentCode = dtoAddd.Department_Code,
                LevelId = dtoAddd.Level_Id,
                SemsterId = dtoAddd.Semster_Id


            };
            if (course == null)
            {
                dbcontext.Courses.Add(addCourses);
                dbcontext.SaveChanges();
                return Ok(addCourses);
            }
            else
            {
                return NotFound("Sorry ! This Course Already Exist In Database");

            }
            //dbcontext.SaveChanges();


        }

        [HttpPut("Update Department GPA")]

        public async Task<IActionResult> GPA_department_Update(string Department_code, float GPA)
        {

            var Department = await dbcontext.Departments.SingleOrDefaultAsync(x => x.DepartmentCode == Department_code);


            if (Department != null)
            {
                if (GPA >= 0 && GPA <= 4)
                {
                    Department.DepartmentGPA = GPA;


                    dbcontext.Departments.Update(Department);
                    dbcontext.SaveChanges();
                    return Ok(Department);
                }
                else
                {
                    return NotFound("PLease Enter The Correct GPA");
                }
            }
            else
            {

                return NotFound("Sorry This Department Already Exit");
            }

        }

        [HttpPost("GetAllCoursesActiveinLevel")]

        public async Task<IActionResult> GetAllCoursesActiveinLevel(int Level)
        {


            var CoursesActive = await dbcontext.Courses.Where(x => x.LevelId == Level).ToListAsync();

            if (CoursesActive != null)
            {

                var courseff = CoursesActive.Select(x => new
                {
                    x.CourseCode,
                    x.CourseHoures,
                    x.SemsterId,
                    x.CourseActive,
                    x.LevelId,
                    x.CourseName

                });

                
                if (Level == 1)
                {
                    foreach (var item in courseff)
                    {
                        Level1 dto = new Level1()
                        {
                            CourseCode1 = item.CourseCode,
                            CourseHoures = item.CourseHoures,
                            Level1Id = item.LevelId,
                            SemsterId = item.SemsterId,
                            CourseName = item.CourseName
                        }
                        ;

                        dbcontext.Level1.Add(dto);
                        dbcontext.SaveChanges();

                    }

                }
                else if (Level == 2)
                {
                    foreach (var item in courseff)
                    {

                        Level2 distention = new Level2
                        {
                            CourseCode2 = item.CourseCode,
                            CourseHoures = item.CourseHoures,
                            Level2Id = item.LevelId,
                            SemsterId = item.SemsterId,
                            CourseName = item.CourseName
                        };

                        dbcontext.Level2.Add(distention);
                        dbcontext.SaveChanges();
                    }

                }
                else if (Level == 3)
                {


                    foreach (var item in courseff)
                    {

                        Level3 distention = new Level3
                        {
                            CourseCode3 = item.CourseCode,
                            CourseHoures = item.CourseHoures,
                            Level3Id = item.LevelId,
                            SemsterId = item.SemsterId,
                            CourseName = item.CourseName
                        };

                        dbcontext.Level3.Add(distention);

                        dbcontext.SaveChanges();

                    }

                }
                else if (Level == 4)
                {

                    foreach (var item in courseff)
                    {

                        Level4 distention = new Level4
                        {
                            CourseCode4 = item.CourseCode,
                            CourseHoures = item.CourseHoures,
                            Level4Id = item.LevelId,
                            SemsterId = item.SemsterId,
                            CourseName = item.CourseName

                        };

                        dbcontext.Level4.Add(distention);

                        dbcontext.SaveChanges();
                    }


                }
                dbcontext.SaveChanges();
                return Ok("Add Courses In  SEMSTER SUCCEFULLY");

            }

            else
            {
                return NotFound("Not Found Courses In This Level");
            }



        }
        [HttpPost("Reasons For Graduation")]

        public async Task<IActionResult> Add3HouresForStudent(string Id)
        {
            var student = await dbcontext.student.SingleOrDefaultAsync(x => x.StudentId == Id);

            if (student != null && student?.GPA >= 2 && (student?.StudentHours >= 102
                && student?.StudentHours < 108 || student?.StudentHours == 123) && student.AllowedHoures != 21)
            {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                student.AllowedHoures = 21;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                dbcontext.SaveChanges();

                return Ok($"3 Hours Have Been Added For The Student :  {student.StudentFullName}");


            }
            else
            {
                return NotFound("Sorry May Be AllowesHours Is { 21 } OR Gpa Less Then 2 OR LevelId Is Not Found OR student Not Found In This Level");


            }
        }
        [HttpPost("Add Sebjuctes in Semseter")]
        public async Task<IActionResult> GetAllCoursesActiveinSemster(int SemsterId, int Level)
        {
            var CoursesActive = await dbcontext.Courses.Where(x => x.LevelId == Level).ToListAsync();
            var CoursesActiveInSemster = CoursesActive.Where(x => x.SemsterId == SemsterId).ToList();
            if (CoursesActive != null)
            {

                var courseff = CoursesActive.Select(x => new
                {
                    x.CourseCode,
                    x.CourseHoures,
                    x.SemsterId,
                    x.CourseActive,
                    x.LevelId,
                    x.CourseName

                });

                if (Level == 1)
                {


                    if (SemsterId == 1)
                    {
                        foreach (var course in courseff)
                        {

                            Semster1 semster1 = new Semster1()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };

                            dbcontext.Semster1.Add(semster1);

                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }
                    else if (SemsterId == 2)
                    {
                        foreach (var course in courseff)
                        {

                            Semster2 semster2 = new Semster2()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };

                            dbcontext.Semster2.Add(semster2);

                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }

                    else
                    {
                        return BadRequest("There IS Not this Semster ");
                    }

                }

                else if (Level == 2)
                {
                    if (SemsterId == 1)
                    {
                        foreach (var course in courseff)
                        {

                            Semster3 semster = new Semster3()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };

                            dbcontext.Semster3.Add(semster);

                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }
                    else if (SemsterId == 2)
                    {
                        foreach (var course in courseff)
                        {

                            Semster4 semster = new Semster4()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };

                            dbcontext.Semster4.Add(semster);

                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }

                    else
                    {
                        return BadRequest("There IS Not this Semster ");
                    }
                }
                else if (Level == 3)
                {
                    if (SemsterId == 1)
                    {
                        foreach (var course in courseff)
                        {

                            Semster5 semster = new Semster5()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };

                            dbcontext.Semster5.Add(semster);

                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }
                    else if (SemsterId == 2)
                    {
                        foreach (var course in courseff)
                        {

                            Semster6 semster = new Semster6()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };

                            dbcontext.Semster6.Add(semster);

                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }

                    else
                    {
                        return BadRequest("There IS Not this Semster ");
                    }

                }
                else if (Level == 4)
                {
                    if (SemsterId == 1)
                    {
                        foreach (var course in courseff)
                        {

                            Semster7 semster = new Semster7()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };
                            if (semster != null)
                            {
                                continue;
                            }
                            else
                            {
                                dbcontext.Semster7.Add(semster);
                            }
                            dbcontext.SaveChanges();

                        }
                        return Ok("ADD SEMSTER SUCCEFULLY");
                    }
                    else if (SemsterId == 2)
                    {
                        foreach (var course in courseff)
                        {

                            Semster8 semster = new Semster8()
                            {
                                CourseCode = course.CourseCode,
                                CourseHoures = course.CourseHoures,
                                CourseName = course.CourseName,
                                SemsterId = course.SemsterId
                            };
                            if (semster != null)
                            {
                                continue;
                            }
                            else
                            {
                                dbcontext.Semster8.Add(semster);
                            }
                            dbcontext.SaveChanges();

                        }
                        return Ok("Add Courses In  SEMSTER SUCCEFULLY");
                    }

                    else
                    {
                        return BadRequest("There IS Not this Semster ");
                    }
                }
                return Ok("Succefully");
            }
            else
            {
                return BadRequest("There IS Not this Level ");
            }
        }
        [HttpGet("Get All Courses")]

        public async Task<IActionResult> GetAllCourses()
        {

            var Courses = await dbcontext.Courses.Where(x => x.CourseCode != null).ToListAsync();
            var CoursesFromTBCourses = Courses.Select(x => new
            {
                x.CourseCode,
                x.CourseHoures,
                x.CourseName

            });

            return Ok(Courses);

        }

        //Active courses in Level

        [HttpPost("Activecourses In Table Active Courses")]

        public async Task<IActionResult> ActiveCourses(string CourseCode)
        {
            var CourseCodeInTbCourses = await dbcontext.Courses
                .Where(x => x.CourseCode == CourseCode).ToListAsync();

            var CourseCodeDetails = CourseCodeInTbCourses.Select(x => new
            {
                x.CourseCode,
                x.CourseHoures,
                x.CourseName

            }).ToList();

            var CourseCodeInTbActiveCours = await dbcontext.ActiveCourses.SingleOrDefaultAsync(x => x.CourseCode == CourseCode); ;
            if (CourseCodeInTbActiveCours == null)
            {
                foreach (var course in CourseCodeDetails)
                {
                    ActiveCourses activeCourses = new ActiveCourses()
                    {

                        CourseCode = course.CourseCode,
                        CourseName = course.CourseName,
                        CourseHours = course.CourseHoures
                    };
                    dbcontext.ActiveCourses.Add(activeCourses);

                }

                dbcontext.SaveChanges();
                return Ok("Add Courses In Active Courses Successfully");
            }
            else
            {
                return BadRequest("Sorry This Courses Existing In Active Courses");
            }

        }


        //Add Active Courses In Level


        [HttpPost("Activecourses In Level")]

        public async Task<IActionResult> ActiveCoursesInLevel(string CourseCode, int LevelId)
        {
            var CourseCodeInTbActiveCourse = await dbcontext.ActiveCourses
                .Where(x => x.CourseCode == CourseCode).ToListAsync();

            var CourseCodeDetails = CourseCodeInTbActiveCourse.Select(x => new
            {
                x.CourseCode,
                x.CourseHours,
                x.CourseName

            }).ToList();

            
            if (CourseCodeInTbActiveCourse != null)
            {

                if (LevelId == 1)
                {

                      foreach (var course in CourseCodeDetails)
                        {
                            Level1 activeCourses = new Level1()
                            {

                                CourseCode1 = course.CourseCode,
                                CourseName = course.CourseName,
                                CourseHoures = course.CourseHours
                            };
                            dbcontext.Level1.Add(activeCourses);
                            dbcontext.SaveChanges();
                        }
                        dbcontext.SaveChanges();

                        return Ok("Add Courses In Active Courses Successfully");
                  
                }



                else if (LevelId == 2)
                {
                   
                        foreach (var course in CourseCodeDetails)
                        {
                            Level2 activeCourses = new Level2()
                            {

                                CourseCode2 = course.CourseCode,
                                CourseName = course.CourseName,
                                CourseHoures = course.CourseHours
                            };
                            dbcontext.Level2.Add(activeCourses);
                            dbcontext.SaveChanges();
                        }
                        dbcontext.SaveChanges();
                        return Ok("Add Courses In Active Courses Successfully");

                  

                }
                else if (LevelId == 3)
                {
                    foreach (var course in CourseCodeDetails)
                    {
                        Level3 activeCourses = new Level3()
                        {

                            CourseCode3 = course.CourseCode,
                            CourseName = course.CourseName,
                            CourseHoures = course.CourseHours
                        };
                        dbcontext.Level3.Add(activeCourses);
                        dbcontext.SaveChanges();
                    }
                    dbcontext.SaveChanges();
                    return Ok("Add Courses In Active Courses Successfully");
                }

                else if (LevelId == 4)
                {

                    foreach (var course in CourseCodeDetails)
                    {
                        Level4 activeCourses = new Level4()
                        {

                            CourseCode4 = course.CourseCode,
                            CourseName = course.CourseName,
                            CourseHoures = course.CourseHours
                        };
                        dbcontext.Level4.Add(activeCourses);
                        dbcontext.SaveChanges();
                    }
                    dbcontext.SaveChanges();

                    return Ok("Add Courses In Active Courses Successfully");
                }

                else
                {
                    return BadRequest($"Sorry There Is Not Level {LevelId}");
                }
            }
            else
            {
                return BadRequest("Sorry Course Not Active ");
            }

           

        }
        
    }
}

       
    