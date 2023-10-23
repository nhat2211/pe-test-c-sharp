using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StaffMemberRepository : IStaffMemberRepository
    {

        public StaffMember findStaffByEmailAndPassword(string email, string password)
        {
            return StaffMemberDao.Instance.findByEmailAndPassword(email, password);
        }
    }
}
