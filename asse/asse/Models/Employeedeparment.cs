using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asse.Models
{
    public class Employeedeparment
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentLocation { get; set; }
        public string EmployeeFName { get; set; }
        public string EmployeelName { get; set; }
        public List<Employeedeparment> employeedeparments { get; set; }
     
    }
    
}