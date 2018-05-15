using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApplication.Models;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        

        List<EmployeeModel> empList = new List<EmployeeModel>();
        
        public ActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>();

            Employee emp1 = new Employee()
            {
                FirstName = "rushi",
                MiddleName = "kesh",
                LastName = "chikka",
                Prefix = "Mr.",
                Suffix = "Jr.",
                PrimaryAddress = "10981 Cominito Alavarez, 50070",
                SecondaryAddress = "dhakdha",

                Salary = 100000,
                PreviousEmployer = "softhq",
                PreviousEmployerAddress = "PreviousEmployerAddress"
            };
            employeeList.Add(emp1);

            Employee satish = new Employee()
            {
                FirstName = "satish",
                MiddleName = "",
                LastName = "singamsetti",
                Prefix = "Mr.",
                Suffix = "Jr.",
                PrimaryAddress = "10981 Cominito Alavarez, 50070",
                SecondaryAddress = "",
                Salary = 100000,
                PreviousEmployer = "softhq",
                PreviousEmployerAddress = "PreviousEmployerAddress"
            };
            EmployeeModel emp = new EmployeeModel()
            {
                employee = satish,
                Language = GetLanguageList()
            };
            EmployeeModel emp2 = new EmployeeModel()
            {
                employee = emp1,
                Language = GetLanguageList()
            };
            empList.Add(emp);
            empList.Add(emp2);
            employeeList.Add(satish);
      
            return View("Employee", empList);
        }
        //added comments
        public ActionResult Create()
        {
            List<SelectListItem> SuffixList = new List<SelectListItem>();
            SuffixList.Add(new SelectListItem { Text = "Jr", Value = "Jr" });
            SuffixList.Add(new SelectListItem { Text = "I", Value = "I" });
            SuffixList.Add(new SelectListItem { Text = "II", Value = "II" });
            ViewBag.SuffixList = SuffixList;
            List<SelectListItem> PrefixList = new List<SelectListItem>();
            PrefixList.Add(new SelectListItem { Text = "Mr.", Value = "Mr." });
            PrefixList.Add(new SelectListItem { Text = "Ms.", Value = "Ms." });
            PrefixList.Add(new SelectListItem { Text = "Dr.", Value = "Dr." });
            ViewBag.PrefixList = PrefixList;
            EmployeeModel emp = new EmployeeModel();

            emp.Language = GetLanguageList();
            return View("Create",emp );
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel postRecord)
        {
            EmployeeModel newRecord = new EmployeeModel();
            newRecord.employee = postRecord.employee;
            newRecord.lang = postRecord.lang;
            newRecord.employee.Prefix = postRecord.PrefixSelected;
            newRecord.employee.Suffix = postRecord.SuffixSelected;
            List<Languages> languagesList = new List<Languages>();
   
            foreach(var item in postRecord.Language)
            {
                languagesList.Add(new Languages()
                {
                    Language = item.Language,
                    Read = item.Read,
                    Write = item.Write,
                    Speak = item.Speak
                });
            }
            newRecord.Language = languagesList;
            empList.Add(newRecord);

            return View("Employee", empList);
        }
        
        private List<Languages> GetLanguageList()
        {
            List<Languages> languagesList = new List<Languages>();
            languagesList.Add(new Languages()
            {
                Language = "English",
                Read = false,
                Write = false,
                Speak = false
            });
            languagesList.Add(new Languages()
            {
                Language = "Hindi",
                Read = false,
                Write = false,
                Speak = false
            });
            languagesList.Add(new Languages()
            {
                Language = "Telugu",
                Read = false,
                Write = false,
                Speak = false
            });
            return languagesList;
        }
    }
}