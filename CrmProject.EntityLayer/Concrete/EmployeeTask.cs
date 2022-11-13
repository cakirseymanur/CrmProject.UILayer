using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProject.EntityLayer.Concrete
{
    public class EmployeeTask
    {
        public int EmployeeTaskID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int AppUserId { get; set; }//Atanan
        public AppUser AppUser { get; set; }
        public int AssigneeUserId { get; set; }//Atayan
        public AppUser AppAssigneeUser { get; set; }
        public List<EmployeeTaskDetail> EmployeeTaskDetail { get; set; }
    }
}
