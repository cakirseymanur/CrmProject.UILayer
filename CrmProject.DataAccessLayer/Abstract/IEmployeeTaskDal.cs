using CrmProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProject.DataAccessLayer.Abstract
{
    public interface IEmployeeTaskDal: IGenericDal<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTasksByEmployee();
        List<EmployeeTask> GetEmployeeTasksByEmployeeAndAssigneeUser();
    }
}
