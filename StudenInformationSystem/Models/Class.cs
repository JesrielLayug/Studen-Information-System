using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
    }
}
