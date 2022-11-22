using CrmProject.DataAccessLayer.Concrete;
using CrmProject.UILayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmProject.UILayer.Controllers
{
    [AllowAnonymous]
    public class ReportController : Controller
    {
        //Static Excel Listesi
        public IActionResult ReportList()
        {
            return View();
        }
        public IActionResult ExcelStatic()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1, 1].Value = "Personel ID";
            workSheet.Cells[1, 2].Value = "Personel Adı";
            workSheet.Cells[1, 3].Value = "Personel Soyadı";

            workSheet.Cells[2, 1].Value = "0001";
            workSheet.Cells[2, 1].Value = "Tuba";
            workSheet.Cells[2, 1].Value = "Zorlu";

            workSheet.Cells[2, 1].Value = "0002";
            workSheet.Cells[2, 1].Value = "Serap";
            workSheet.Cells[2, 1].Value = "Beran";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "personeller.xlsx");
        }

        public List<CustomerVM>CustomerList()
        {
            List<CustomerVM> customerVMs = new List<CustomerVM>();
            using(var context= new Context())
            {
                customerVMs = context.Customers.Select(x => new CustomerVM
                {
                    Mail = x.CustomerMail,
                    Name = x.CustomerName,
                    Surname = x.CustomerSurname,
                    Phone = x.CustomerPhone
                }).ToList();
            }
            return customerVMs;
        }
        public IActionResult DynamicExcel()
        {
            return View();
        }
    }
}
