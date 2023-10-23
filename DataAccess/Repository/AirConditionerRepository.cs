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
        AirConditionDAO airConditionDAO;
        public void create(AirConditioner airConditioner)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AirConditioner> findAll()
        {
            throw new NotImplementedException();
        }

        public AirConditioner findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(AirConditioner airConditioner)
        {
            throw new NotImplementedException();
        }
    }
}
