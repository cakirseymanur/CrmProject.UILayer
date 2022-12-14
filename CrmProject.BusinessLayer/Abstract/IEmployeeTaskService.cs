using CrmProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProject.BusinessLayer.Abstract
{
    public interface IEmployeeTaskService:IGenericService<EmployeeTask>
    {
        List<EmployeeTask> TGetEmployeeTasksByEmployee();
        List<EmployeeTask> TGetEmployeeTasksByEmployeeAndAssigneeUser();
        List<EmployeeTask> TGetEmployeeTasksByUserId(int id);
    }
}
