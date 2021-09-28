using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VehicleRepository.Models
{
    public class Vehicle 
    {
        [Required(ErrorMessage ="required")]
        public int VehicleID { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        [StringLength(4,ErrorMessage ="Please enter 4 numbers only")]
        public int Year { get; set; }
        [StringLength(24 , ErrorMessage ="Please enter 24 chars only")]
        [RegularExpression("^[a-zA-Z0-9]{8}\\d{5}$",ErrorMessage ="Please enter VIN as minimum of 8 alphanumerics and last 5 character should be numbers")]
        public string VIN { get; set; }

        public int VehicleType { get; set; }

        public int VehicleStatus { get; set; }

    }
    public class CheckPropertyValidation
    {
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
