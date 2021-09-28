using System;
using VehicleRepository.Interface;
using VehicleRepository.Models;

namespace VehicleRepository
{
    public class ClsTransVehicles:ITransferVehicles
    {
        public  bool TransferSemiVehicles(VehicleTransRequest vehicle)
        {
            if (vehicle is null) { return false; }
            if (vehicle.VehicleStatus!= StatusTypes.standby.ToString()) { return false; }
            if (vehicle.ToBranchID != null) { return false; }
            if (vehicle.FromDistributionCentreID!=null & vehicle.ToDistributionCentreID!=null)
            {
                return true;
            }
            return true;
        }

        public bool TransferTrucks(VehicleTransRequest vehicle)
        {

            if (vehicle is null) { return false; }
            if (vehicle.VehicleStatus != StatusTypes.standby.ToString()) { return false; }
            if (vehicle.ToBranchID == null || vehicle.FromBranchID==null) { return false; }
            if (vehicle.FromDistributionCentreID != null & vehicle.ToDistributionCentreID != null)
            {
                return false;
            }
            if (vehicle.FromBranchID != null & vehicle.ToBranchID != null) { return true; }
            return true;
        }

        public bool Transfervan(VehicleTransRequest vehicle)
        {

            if (vehicle is null) { return false; }
            if (vehicle.VehicleStatus != StatusTypes.standby.ToString()) { return false; }
            if (vehicle.ToBranchID == null || vehicle.FromBranchID == null ) { return false; }
            if (vehicle.FromDistributionCentreID != null & vehicle.ToDistributionCentreID != null)
            {
                return false;
            }
            if (vehicle.FromBranchID != null & vehicle.ToBranchID != null) { return true; }
            return true;
        }

        //public bool TransferVehicles(Vehicle vehicle , string location)
        //{

        //    return true;
        //}
    }
}
