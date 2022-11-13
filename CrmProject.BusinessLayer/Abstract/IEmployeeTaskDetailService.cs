using CrmProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProject.BusinessLayer.Abstract
{
    public interface IEmployeeTaskDetailService:IGenericService<EmployeeTaskDetail>
    {
        List<EmployeeTaskDetail> TGetEmployeeTaskDetailGetByID(int id);
    }
}
