using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Dto
{
    public class DtoLogin
    {
     
       
        public string? Id { get; set; }=null;
       public string? Password { get; set; }=null ;
        public string? User {  get; set; }=null;
        /*
         
          var student = dbcontext.Students;
            var Adminpassword = await dbcontext.Admins.Where(s => s.AdminPassword==dtoLogin.Password).ToListAsync();
            var AdminUser = await dbcontext.Admins.Where(s => s.AdminUserName == dtoLogin.AdminUser).ToListAsync();
            var StudentId = await dbcontext.Students.Where(s => s.StudentId == dtoLogin.Usr_Id).ToListAsync();
            var StudentPassword = await dbcontext.Students.Where(s => s.StudentPassword == dtoLogin.Password).ToListAsync();
            var Syste
         */
    }
}
