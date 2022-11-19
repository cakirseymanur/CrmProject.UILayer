using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmProject.UILayer.Areas.EmployeeArea.Controllers
{
    [Area("EmployeeArea")]
    [AllowAnonymous]
    public class DashboardAreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
