using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Dto
{
    public class dtoAddDourse
    {
        public string Course_Code { get; set; }
        public string Course_Name { get; set; }
        public int Course_Hours { get; set; }
        public string Course_Active { get; set; }
        public int Level_Id { get; set; }
        public string Department_Code { get; set; }
        public int Semster_Id { get; set; }

    }
}
