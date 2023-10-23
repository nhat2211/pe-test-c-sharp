using AirConditionBusiness.Models;

namespace DataAccess
{
    public class AirConditionDAO
    {

        private static AirConditionDAO instance;
        private AirConditionerShop2023DbContext context;

        private AirConditionDAO(){}

        public static AirConditionDAO Instance()
        {
            if (instance == null)
            {
                instance = new AirConditionDAO();
            }
            return instance;
        }



    }
}