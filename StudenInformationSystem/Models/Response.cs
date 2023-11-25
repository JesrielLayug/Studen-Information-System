using StudenInformationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Models
{
    public class Response
    {
        public bool IsSucess {  get; set; }
        public string Message { get; set; }
        public DTOStudentInformation Data { get; set; }
    }
}
