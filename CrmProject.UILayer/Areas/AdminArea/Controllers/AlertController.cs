using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmProject.UILayer.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AllowAnonymous]
    public class AlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
