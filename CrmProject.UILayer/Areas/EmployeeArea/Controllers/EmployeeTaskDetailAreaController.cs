using CrmProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmProject.UILayer.Areas.EmployeeArea.Controllers
{
    [Area("EmployeeArea")]
    public class EmployeeTaskDetailAreaController : Controller
    {
        private readonly IEmployeeTaskDetailService _employeeTaskDetailService;

        public EmployeeTaskDetailAreaController(IEmployeeTaskDetailService employeeTaskDetailService)
        {
            _employeeTaskDetailService = employeeTaskDetailService;
        }

        public IActionResult Index(int id)
        {
            var values = _employeeTaskDetailService.TGetEmployeeTaskDetailGetByID(id);
            return View(values);
        }
    }
}
