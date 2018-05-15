using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApplication.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string PrimaryAddress { get; set; }
        public string SecondaryAddress { get; set; }
        public int LanguageId { get; set; }
        public int Salary { get; set; }
        public string PreviousEmployer { get; set; }
        public string PreviousEmployerAddress { get; set; }
    }
}