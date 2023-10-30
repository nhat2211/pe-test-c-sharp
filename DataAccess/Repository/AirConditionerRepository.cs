using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AirConditionerRepository : IAirConditionerRepository
    {
       
        public void create(AirConditioner airConditioner)
        {
            AirConditionDAO.Instance.create(airConditioner);
        }

        public void delete(int id)
        {
            AirConditionDAO.Instance.delete(id);
        }

        public List<AirConditioner> findAll()
        {
            return AirConditionDAO.Instance.findAll();
        }

        public AirConditioner findById(int id)
        {
            return AirConditionDAO.Instance.findById(id);
        }

        public void update(AirConditioner airConditioner)
        {
            AirConditionDAO.Instance.update(airConditioner);
        }

        public SupplierCompany findCompanyByAirConditoner(string supplierId)
        {
            return AirConditionDAO.Instance.findCompanyByAirConditoner(supplierId);

        }

        public List<AirConditioner> findByFeatureAndQuantity(string feature, int quantity)
        {
            return AirConditionDAO.Instance.findByFeatureAndQuantity(feature, quantity);
        }
    }
}
