using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Registration.Data;
using RegistrationSystem.Dto;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class LoginUser : ControllerBase
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;

        //public LoginUser(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login([FromForm] DtoLogin dto)
        //{
        //    //var user = await _userManager.FindByIdAsync();
        //    if (user != null && await _userManager.CheckPasswordAsync(user))
        //    {
        //        // Here you can generate a token or a cookie for the session
        //        return Ok("User authenticated");
        //    }

        //    return Unauthorized();
        //}
        // }


        private readonly AppDbContext dbcontext;

        public LoginUser(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpPost("Login")]

        public async Task<IActionResult> Loginn([FromForm] DtoLogin dtologin)
        {
            var StudentPassword = await dbcontext.student.Where(s => s.StudentPassword == dtologin.Password).ToListAsync();

            if (dtologin.User == "Admin")
            {
                var AdminUser = await dbcontext.Admins.SingleOrDefaultAsync(s => s.AdminUserName == dtologin.Id);
                var Password = await dbcontext.Admins.SingleOrDefaultAsync(s => s.AdminPassword == dtologin.Password);

                if (AdminUser != null && Password != null)
                {
                    return Ok($"{AdminUser.AdminFullName}  Login Successfully");
                }
                else
                {
                    return NotFound("Not Found Password Or User In Database");
                }
            }
            else if (dtologin.User == "Student")
            {
                var StudentId = await dbcontext.student.SingleOrDefaultAsync(s => s.StudentId == dtologin.Id);
                if (StudentId != null) {
                    return Ok($"{StudentId.StudentFullName} Login Succefully");
                }
            
            else
            {
                return NotFound("Not Found Password Or Student In Database");

            }
        }
        
                else
                {
                    return NotFound("Not Found Password Or User In Database");
                }
            }
           

        }



    } 
