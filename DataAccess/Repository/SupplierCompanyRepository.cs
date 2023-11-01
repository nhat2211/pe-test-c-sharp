using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SupplierCompanyRepository : ISupplierCompanyRepository
    {
        public List<SupplierCompany> GetAll()
        {
            return SupplierDAO.getInstance().findAll();
        }
    }
}
