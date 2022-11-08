using CrmProject.DataAccessLayer.Abstract;
using CrmProject.DataAccessLayer.Repository;
using CrmProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProject.DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository<Category>,ICategoryDal
    {

    }
}
