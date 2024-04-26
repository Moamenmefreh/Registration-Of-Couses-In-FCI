using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/[controller]")]
    [ApiController]
    public class SystemUser : ControllerBase
    {
        private readonly AppDbContext dbcontext;

        public SystemUser(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpPost("AddAdmin")]
        public async Task<IActionResult> AddAdmin([FromForm] DtoAdmin dtoadmin)
        {

            var Admin = await dbcontext.Admins.SingleOrDefaultAsync(x => x.AdminUserName == dtoadmin.AdminUserName);
            if (Admin == null)
            {
                Admins AddAdmin = new Admins
                {
                    AdminUserName = dtoadmin.AdminUserName,
                    AdminFullName = dtoadmin.AdminFullname,
                    AdminPassword = dtoadmin.AdminPassword


                };

                dbcontext.Admins.Add(AddAdmin);

                dbcontext.SaveChanges();

                return Ok(AddAdmin);
            }
            else
                return NotFound("Sorry Admin Is Existing");

        }

        [HttpDelete("Delete_Admin")]
        public async Task<IActionResult> DeleteAdmin(string AdminUserName)
        {
            var Admin = await dbcontext.Admins.SingleOrDefaultAsync(x => x.AdminUserName == AdminUserName);
            if (Admin != null)
            {
                dbcontext.Admins.Remove(Admin);
                 dbcontext.SaveChanges();
               
                return NotFound("Deleted Successfully");
                ;
            }
            else
                return NotFound("This Admin does not Already Exist");
        }
    }
}