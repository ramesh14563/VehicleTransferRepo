using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRepository.Models
{
   public  class VehicleTransRequest
    {
        public string VehicleStatus { get; set; }
       // public string VehicleType { get; set; }
        public string VehicleID { get; set; }
        public string  FromDistributionCentreID { get; set; }
        public string ToDistributionCentreID { get; set; }

        public string  FromBranchID { get; set; }
        public string ToBranchID { get; set; }
    }
}
