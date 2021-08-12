using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NumberInStockValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            if(movie.NumberInStock < 1 || movie.NumberInStock > 100)
            {
                return new ValidationResult("Number in stock must be between 1 and 100.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}