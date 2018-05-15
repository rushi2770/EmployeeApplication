using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApplication.Models
{
    public class EmployeeModel
    {
        public Employee employee { get; set; }
        //public string language { get; set; }
        public string SuffixSelected { get; set; }
        public string PrefixSelected { get; set; }
        public List<Languages> Language { get; set; }
        public Languages lang { get; set; }
    }
}