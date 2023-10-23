using AirConditionBusiness.Models;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class AirConditionDAO
    {

        private static AirConditionDAO instance;
        private AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();

        private AirConditionDAO()
        {

        }

        public static AirConditionDAO Instance()
        {
            if (instance == null)
            {
                instance = new AirConditionDAO();
            }
            return instance;
        }

        public void create(AirConditioner airConditioner)
        {
            try
            {
                context.AirConditioners.Add(airConditioner);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }




    }
}