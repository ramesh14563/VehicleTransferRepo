using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using VehicleRepository.Models;

namespace DataAccessLayer
{
    public class DataObjects
    {
        public static List<Vehicle> getVehicles()
        {
           return new List<Vehicle>() {
               new Vehicle() {VehicleID=101, Make = "BMW", Model = "3 Series", VIN = "JH4KA7650MC0JHUYTD02609", Year = 1991,VehicleStatus=0 ,VehicleType=0 },
               new Vehicle() {VehicleID=102, Make = "BMW", Model = "X5", VIN = "5UXFE8C50AL3JHZYTD10357", Year = 2010,VehicleStatus=1 ,VehicleType=1  }, 
               new Vehicle() { VehicleID=103,Make = "BMW", Model = "Z3", VIN = "WBACK73401LJJHUKTD15287", Year = 2001,VehicleStatus=2 ,VehicleType=2 },
               new Vehicle() { VehicleID=104,Make = "Audi", Model = "2006", VIN = "WAUHE94F16N0JHUTTD45755", Year = 2006 ,VehicleStatus=3 ,VehicleType=0 },
               new Vehicle() { VehicleID=105,Make = "Audi", Model = "A6", VIN = "WAUFGBFC3DN0JHUYTD44423", Year = 2013 ,VehicleStatus=3 ,VehicleType=0 },
               new Vehicle() { VehicleID=106,Make = "Jaguar", Model = "2002", VIN = "SAJAA02AX2FMJHKKTD34192", Year = 2002 ,VehicleStatus=2 ,VehicleType=1 },
               new Vehicle() { VehicleID=107,Make = "Jaguar", Model = "1990", VIN = "SAJDDALW4LM4JHUYJD85334", Year = 1990,VehicleStatus=2 ,VehicleType=0  },
               new Vehicle() { VehicleID=108,Make = "Jaguar X-Type", Model = "2004", VIN = "SAJAA51M04XDYLUYTD74352", Year = 2004,VehicleStatus=3 ,VehicleType=0  }

           };       

        }
        //map vehicles to vehicletypes
        public static List<LocationTypes> getLocationTypes()
        {

            return new List<LocationTypes> { new LocationTypes() { LocationNumber = 1, LocationTypename = "DistributedCenters" }, new LocationTypes() { LocationNumber = 2, LocationTypename = "Branch" } };
        }
        public static List<DistributedCentre> getDistributionCenters()
        {
            return new List<DistributedCentre>
            {
                new DistributedCentre(){DistrubutedCentreNumber=001,DistributedCenterName="Audi",branches=new List<Branch>(){ new Branch(){BranchID=201,BranchName="Branch201"},
            new Branch(){BranchID=202,BranchName="Branch202"} } },
                 new DistributedCentre(){DistrubutedCentreNumber=002,DistributedCenterName="BMW"},
                 new DistributedCentre(){DistrubutedCentreNumber=003,DistributedCenterName="Ford"},
            };
        }
        public static List<Branch> GetBranches()
        {

            var branches = new List<Branch>
            {
               new Branch(){BranchID=201,BranchName="Branch201",
                vehicles=new List<Vehicle>()
                { 
                     //This stub data can be used to showing negative case to transfer between distribution centers -
                    new Vehicle() { VehicleID=104,Make = "Audi", Model = "2006", VIN = "WAUHE94F16N0JHUTTD45755", Year = 2006 ,VehicleStatus=3 ,VehicleType=0 },
                    //This stub data can be used to transfer between distribution centers - semi vehicle & stand-by status
                    new Vehicle() { VehicleID=105,Make = "Audi", Model = "A6", VIN = "WAUFGBFC3DN0JHUYTD44423", Year = 2013 ,VehicleStatus=0 ,VehicleType=2 }
                } 
            },
            new Branch(){BranchID=202,BranchName="Branch202",vehicles=new List<Vehicle>(){ new Vehicle() { VehicleID = 101, Make = "BMW", Model = "3 Series", VIN = "JH4KA7650MC0JHUYTD02609", Year = 1991, VehicleStatus = 0, VehicleType = 2 } } },
            new Branch(){BranchID=901,BranchName="Branch901",vehicles=new List<Vehicle>(){ new Vehicle() { VehicleID = 108, Make = "Jaguar X-Type", Model = "2004", VIN = "SAJAA51M04XDYLUYTD74352", Year = 2004, VehicleStatus = 1, VehicleType = 2 } } },
            new Branch(){BranchID=902,BranchName="Branch902", vehicles=new List<Vehicle>(){ new Vehicle() { VehicleID = 107, Make = "Jaguar", Model = "1990", VIN = "SAJDDALW4LM4JHUYJD85334", Year = 1990, VehicleStatus = 0, VehicleType = 2 }} },
           //This stub data can be used to transfer between distribution centers - semi vehicle & stand-by status
            new Branch(){BranchID=903,BranchName="Branch903", vehicles=new List<Vehicle>(){   new Vehicle() { VehicleID=106,Make = "Jaguar", Model = "2002", VIN = "SAJAA02AX2FMJHKKTD34192", Year = 2002 ,VehicleStatus=2 ,VehicleType=1 }} },
            new Branch(){BranchID=904,BranchName="Branch904", vehicles=new List<Vehicle>(){   new Vehicle() { VehicleID=108,Make = "Jaguar", Model = "2002", VIN = "SAJAA02AX2FMJHKKTD34192", Year = 2002 ,VehicleStatus=0 ,VehicleType=0 }} },
            new Branch(){BranchID=905,BranchName="Branch905"},
            new Branch(){BranchID=906,BranchName="Branch906"},
            new Branch(){BranchID=907,BranchName="Branch907"},
            new Branch(){BranchID=908,BranchName="Branch908"},
            new Branch(){BranchID=909,BranchName="Branch909"}
            };

            return branches;
        }
    }
}
