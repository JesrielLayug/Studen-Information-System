using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Models.DTOs
{
    public class DTOStudentInformation
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public string Credits {  get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public List<string> Subjects { get; set; }
    }
}
