using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleCansparkDemo.Controllers
{
    public class Employee
    {
        public string EmpName { get; set; }

        public string EmpAddress { get; set; }

        public string EmpCity { get; set; }

    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> StrEmp = new List<string>();
            List<Employee> ListEmp = new List<Employee>();
            ListEmp.Add(new Employee { EmpName = "Varma", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Ashwin", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Chinnaraj", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Sagar", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Hari", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Ajeya", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Chetan", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Harish", EmpAddress = "JPNagar", EmpCity = "Bangalore" });
            ListEmp.Add(new Employee { EmpName = "Chandrashekhar", EmpAddress = "JPNagar", EmpCity = "Bangalore" });


            foreach (var item in ListEmp)
            {
                Console.WriteLine(ListEmp);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}