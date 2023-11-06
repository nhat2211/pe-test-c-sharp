using AirConditionBusiness.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class AirConditionDAO
    {

        private static AirConditionDAO instance;
   

        private AirConditionDAO()
        {

        }

        public static AirConditionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AirConditionDAO();
                }
                return instance;
            }
           
        }

        public void create(AirConditioner airConditioner)
        {
            try
            {
                using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
                context.AirConditioners.Add(airConditioner);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }

        public void update(AirConditioner airConditioner)
        {
            try
            {
                using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
                context.Entry<AirConditioner>(airConditioner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void delete(int id)
        {
            try
            {
                using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
                var air = context.AirConditioners.SingleOrDefault(a => a.AirConditionerId == id);
                context.AirConditioners.Remove(air);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AirConditioner> findAll()
        {
            List<AirConditioner> airs;
            IQueryable<AirConditioner> airConditioners = null;
            try
            {
                using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
                airConditioners = context.AirConditioners.Include(air=> air.Supplier);
                airs = airConditioners.ToList();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }

            return airs;

        }

        public AirConditioner findById(int id)
        {
            AirConditioner air = null;
            try
            {
                using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
                air = context.AirConditioners.Include(a => a.Supplier).SingleOrDefault(a => a.AirConditionerId == id);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }

            return air;
        }

        public SupplierCompany findCompanyByAirConditoner(string supplierId)
        {
            using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
            
            var supplierCompany = context.SupplierCompanies.ToList().Find(sup => sup.SupplierId.Equals(supplierId));
            return supplierCompany;
        }

        public List<AirConditioner> findByFeatureAndQuantity(string feature, int quantity)
        {
            using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
            return context.AirConditioners.Include(air => air.Supplier).Where(a => a.FeatureFunction.Contains(feature) || a.Quantity == quantity).ToList();
        }


    }
}