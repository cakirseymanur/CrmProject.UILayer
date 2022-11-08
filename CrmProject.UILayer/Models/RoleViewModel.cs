using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrmProject.UILayer.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen Rol giriniz.")]
        public string RoleName { get; set; }
    }
}
