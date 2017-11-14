using System;
using System.ComponentModel.DataAnnotations;

namespace SantaTracker.Models
{
    public class Location
    {
        public Location(string locationName, string address, string city, DateTime startDate, DateTime endDate, bool sleighProvided)
        {
            LocationName = locationName;
            Address = address;
            City = city;
            StartDate = startDate;
            EndDate = endDate;
            SleighProvided = sleighProvided;
        }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Sleigh Provided")]
        public bool SleighProvided { get; set; }
    }
}
