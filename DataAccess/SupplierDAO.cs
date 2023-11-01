using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;
        private SupplierDAO() { }
        public static SupplierDAO getInstance()
        {
            if (instance == null)
            {
                instance = new SupplierDAO();
            }

            return instance;
        }

        public List<SupplierCompany> findAll()
        {
            using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
            return context.SupplierCompanies.ToList();

        }
    }
}
