using System;
using System.Collections.Generic;
using System.Text;
using VehicleRepository.Models;

namespace VehicleRepository.Interface
{
    public interface ITransferVehicles
    {
        bool TransferSemiVehicles(VehicleTransRequest vehicle);
        bool TransferTrucks(VehicleTransRequest vehicle);
        bool Transfervan(VehicleTransRequest vehicle);

    }
}
