using System;
using System.Collections.Generic;
using System.Text;
using VehicleRepository.Models;

namespace VehicleRepository.Interface
{
   public interface IVehicle
    {
        bool AddVehicles(Vehicle vehicle);
        List<Vehicle>  getVehicles();

    }
}
