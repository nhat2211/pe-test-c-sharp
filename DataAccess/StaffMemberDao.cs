using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirConditionBusiness.Models;

namespace DataAccess
{
    public class StaffMemberDao
    {
        private static StaffMemberDao instance;

        private StaffMemberDao() { }

        public static StaffMemberDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffMemberDao();
                }
                return instance;
            }
        }

        public StaffMember findByEmailAndPassword(string email, string password)
        {
            StaffMember staff = null;
            try
            {
                using AirConditionerShop2023DbContext context = new AirConditionerShop2023DbContext();
                staff = context.StaffMembers.ToList().Find(s => s.EmailAddress.Equals(email)
                && s.Password.Equals(password));

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            return staff;

            
        }


    }
}
