using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRepository.Models
{
    public class DistributedCentre : @base
    {
        public int DistrubutedCentreNumber { get; set; }
        public string DistributedCenterName { get; set; }
        public List<Branch> branches { get; set; }
    }
}
