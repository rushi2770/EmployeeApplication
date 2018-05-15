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

            List<Languages> languagesList = new List<Languages>();
            languagesList.Add(new Languages()
            {
                Language = "english",
                Read = true,
                Write = true,
                Speak = true
            });
            languagesList.Add(new Languages()
            {
                Language = "Hindi",
                Read = true,
                Write = true,
                Speak = true
            });
            languagesList.Add(new Languages()
            {
                Language = "Telugu",
                Read = true,
                Write = true,
                Speak = true
            });

            List<EmployeeModel> empList = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel()
            {
                employee = satish,
                Language = languagesList
            };
            EmployeeModel emp2 = new EmployeeModel()
            {
                employee = emp1,
                Language = languagesList
            };
            empList.Add(emp);
            empList.Add(emp2);
            employeeList.Add(satish);
            // ViewBag.Languages = LanguagesList;
            // return View("Index", employeeList);
            //return View("Create");
            return View("Employee", empList);
        }
        //added comments
        public ActionResult Create()
        {
            List<SelectListItem> SuffixList = new List<SelectListItem>();
            SuffixList.Add(new SelectListItem { Text = "Jr", Value = "1" });
            SuffixList.Add(new SelectListItem { Text = "I", Value = "2" });
            SuffixList.Add(new SelectListItem { Text = "II", Value = "3" });
            ViewBag.SuffixList = SuffixList;
            List<SelectListItem> PrefixList = new List<SelectListItem>();
            PrefixList.Add(new SelectListItem { Text = "Mr.", Value = "1" });
            PrefixList.Add(new SelectListItem { Text = "Ms.", Value = "2" });
            PrefixList.Add(new SelectListItem { Text = "Dr.", Value = "3" });
            ViewBag.PrefixList = PrefixList;
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel postRecord)
        {

            return View();
        }
    }
}