﻿using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal interface IStaffMemberRepository
    {
        public StaffMember findStaffByEmailAndPassword(String email, String password);

    }
}
