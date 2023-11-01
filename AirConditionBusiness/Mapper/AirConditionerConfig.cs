using AirConditionBusiness.DTO;
using AirConditionBusiness.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionBusiness.Mapper
{
    public class AirConditionerConfig
    {
        public static void createMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AirConditioner, AirConditionerDTO>()
                .ForMember(des => des.SupplierName, act=> act.MapFrom(src=>src.Supplier.SupplierName));

        }
    }
}
