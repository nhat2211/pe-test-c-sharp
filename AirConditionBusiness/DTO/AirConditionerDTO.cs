using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionBusiness.DTO
{
    public class AirConditionerDTO
    {
        public string AirConditionerName { get; set; } = null!;

        public string? Warranty { get; set; }

        public string? SoundPressureLevel { get; set; }

        public string? FeatureFunction { get; set; }

        public int? Quantity { get; set; }

        public double? DollarPrice { get; set; }

        public string? SuppleName { get; set; }
    }
}
