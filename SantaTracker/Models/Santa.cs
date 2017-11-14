using System;
using System.ComponentModel.DataAnnotations;

namespace SantaTracker.Models
{
    public class Santa
    {
        public Santa(string firstName, string lastName, bool hasOwnSuit, bool hasRealBeard, decimal payRate)
        {
            FirstName = firstName;
            LastName = lastName;
            HasOwnSuit = hasOwnSuit;
            HasRealBeard = hasRealBeard;
            PayRate = payRate;
        }

        [Display(Name = "First Name")]
        public string FirstName{ get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Own Suit?")]
        public bool HasOwnSuit { get; set; }

        [Display(Name = "Real Beard?")]
        public bool HasRealBeard { get; set; }

        [Display(Name = "Pay Rate")]
        [DataType(DataType.Currency)]
        public decimal PayRate { get; set; }

        public string GetFullName()
        {
            if (!String.IsNullOrEmpty(FirstName) && !String.IsNullOrEmpty(LastName))
            {
                return FirstName + " " + LastName;
            }
            else
                return "No full name";
        }
    }
}
