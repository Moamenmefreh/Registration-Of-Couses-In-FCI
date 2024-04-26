using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Dto
{
    public class LoginForStudent1
    {
        public int StudentId { get; set; }
        public string StudentPassword { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
      public bool IsAuthenticated { get; set; }
    }
}
