using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRepository.Models
{
    public enum VehicleTypes
    {
        truck = 0,
        van = 1,
        semi = 2,
    }
    public enum StatusTypes
    {
        standby = 0,
        transit = 1,
        service = 2,
        repair = 3,
    }
}
