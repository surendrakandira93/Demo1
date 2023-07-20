using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime DOB { get; set; } 
        public string Gender { get; set; }
        public int Department { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; } 
    }
}