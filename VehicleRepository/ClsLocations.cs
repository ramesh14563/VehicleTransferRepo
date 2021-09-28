using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Interface;
using VehicleRepository.Models;

namespace VehicleRepository
{
    public class ClsLocations : ILocations
    {

       
        public List<Branch> GetBranches()
        {
            var branches = new List<Branch>();
            try
            {
                 branches = DataAccessLayer.DataObjects.GetBranches();
            }
            catch {
            
            
            }
            return branches;
        }


        public List<DistributedCentre> getDistributionCenters()
        {
            var distcenters = new List<DistributedCentre>();
            try
            {
                distcenters = DataAccessLayer.DataObjects.getDistributionCenters();
            }
            catch
            {


            }
            return distcenters;
        }

        public List<LocationTypes> getLocationTypes()
        {
            var loctypes = new List<LocationTypes>();
            try
            {
                loctypes = DataAccessLayer.DataObjects.getLocationTypes();
            }
            catch
            {


            }
            return loctypes;
        }
    }
}
