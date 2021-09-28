using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using VehicleRepository;
using VehicleRepository.Interface;
using VehicleRepository.Models;

namespace NUnitVehicleSol
{
    public class Tests
    {
        private ITransferVehicles _trans = null;
        [SetUp]
        public void Setup()
        {
            _trans = new ClsTransVehicles();
        }
        [Test]
        public void TestTransferTrucktoBranch()
        {
            VehicleTransRequest objVeh = new VehicleTransRequest() {FromBranchID= "Branch904", ToBranchID= "Branch905", FromDistributionCentreID=null,VehicleStatus=StatusTypes.standby.ToString(),VehicleID= "108" };
           bool res= _trans.TransferTrucks(objVeh);
            Assert.AreEqual(true, res);

        }
        [Test]
        public void TestTransferVantoBranch()
        {
            VehicleTransRequest objVeh = new VehicleTransRequest() { FromBranchID = "Branch904", ToBranchID = "Branch905", FromDistributionCentreID = null, VehicleStatus = StatusTypes.standby.ToString(), VehicleID = "108" };
            bool res = _trans.Transfervan(objVeh);
            Assert.AreEqual(true, res);

        }
        [Test]
        public void TestTransferSemitoBranch()
        {
            VehicleTransRequest objVeh = new VehicleTransRequest() { FromBranchID = null, ToBranchID = null, FromDistributionCentreID = "001",ToDistributionCentreID="003", VehicleStatus = StatusTypes.standby.ToString(), VehicleID = "104" };
            bool res = _trans.TransferSemiVehicles(objVeh);
            Assert.AreEqual(true, res);

        }

        [Test]
        public void TestNegativeTransferTrucktoBranch()
        {
            VehicleTransRequest objVeh = new VehicleTransRequest() { FromBranchID = "Branch904", ToBranchID = null, FromDistributionCentreID = null, VehicleStatus = StatusTypes.standby.ToString(), VehicleID = "108" };
            bool res = _trans.TransferTrucks(objVeh);
            Assert.AreEqual(false, res);

        }
        [Test]
        public void TestNegativeTransferVantoBranch()
        {
            VehicleTransRequest objVeh = new VehicleTransRequest() { FromBranchID = "Branch904", ToBranchID = null, FromDistributionCentreID = null, VehicleStatus = StatusTypes.standby.ToString(), VehicleID = "108" };
            bool res = _trans.Transfervan(objVeh);
            Assert.AreEqual(false, res);

        }
        [Test]
        public void TestNegativeTransferSemitoBranch()
        {
            VehicleTransRequest objVeh = new VehicleTransRequest() { FromBranchID = null, ToBranchID = "Branch904", FromDistributionCentreID = null, ToDistributionCentreID = "003", VehicleStatus = StatusTypes.standby.ToString(), VehicleID = "104" };
            bool res = _trans.TransferSemiVehicles(objVeh);
            Assert.AreEqual(false, res);

        }
        [Test]
        public void ValidateModel()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();
            var veh = new Vehicle
            {  Make = "BMW", Model = "3 Series", Year = 91, VIN = "JH4KA7650MC0JHUYTD0ER2609", VehicleStatus = 0, VehicleType = 0 };
            var errorcount = myValidation(veh).Count();
            Assert.AreEqual(0, errorcount);
       
        }
      

        public IList<ValidationResult> myValidation(object model)
        {
            var result = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);
            Validator.TryValidateObject(model, validationContext, result);
            if (model is IValidatableObject) (model as IValidatableObject).Validate(validationContext);

            return result;



        }
    }
}