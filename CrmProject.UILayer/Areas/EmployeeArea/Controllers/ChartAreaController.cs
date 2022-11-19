using CrmProject.UILayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmProject.UILayer.Areas.EmployeeArea.Controllers
{
    [Area("EmployeeArea")]
    public class ChartAreaController : Controller
    {
        List<DepartmantSalary> departmantSalaries = new List<DepartmantSalary>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DepartmantChart()
        {
            departmantSalaries.Add(new DepartmantSalary()
            {
                departmantName = "Muhasebe",
                salaryAvg = 10000
            });
            departmantSalaries.Add(new DepartmantSalary()
            {
                departmantName = "IT",
                salaryAvg = 30000
            });
            departmantSalaries.Add(new DepartmantSalary()
            {
                departmantName = "Satış",
                salaryAvg = 20000
            });
            return Json(new {jsonList=departmantSalaries});
        }
    }
}
