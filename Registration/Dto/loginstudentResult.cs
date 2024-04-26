using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Dto
{
    public class loginstudentResult
    {
        public int StudentId { get; set; }
        public string StudentPassword { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
    }
}
