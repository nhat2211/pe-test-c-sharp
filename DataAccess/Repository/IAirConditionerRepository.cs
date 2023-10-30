using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAirConditionerRepository
    {
        public List<AirConditioner> findAll();

        public AirConditioner findById(int id);

        public void create(AirConditioner airConditioner);

        public void update(AirConditioner airConditioner);
        public void delete(int id);

        public SupplierCompany findCompanyByAirConditoner(string id);

        public List<AirConditioner> findByFeatureAndQuantity(string feature, int quantity);

    }
}
