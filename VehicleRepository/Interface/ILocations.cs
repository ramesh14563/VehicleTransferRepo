using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Models;

namespace VehicleRepository.Interface
{
    public interface ILocations
    {
        List<LocationTypes> getLocationTypes();
        List<DistributedCentre> getDistributionCenters();
        List<Branch> GetBranches();
    }
}
