using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {


        //navigation property
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "Date Arrived")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ArriveDate { get; set; }
        [Display(Name = "Date Departed")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DepartDate { get; set; }
        public string Comment { get; set; }
        public string Clean { get; set; }
        [Display(Name = "Pet Friendly")]
        public bool PetFriendly { get; set; }
        public bool Pool { get; set; }
        [Display(Name = "On Site Dining")]
        public bool OnSiteDining { get; set; }
        [Display(Name = "House Keeping")]
        public bool HouseKeeping { get; set; }
        public bool Concierge { get; set; }
        [Display(Name = "This location is near a beach")]
        public bool NearBeach { get; set; }
        [Display(Name = "If yes, how far was the walk?")]
        public string BeachMiles { get; set; }
        [Display(Name = "This location is near the mountains")]
        public bool NearMountain { get; set; }
        [Display(Name = "If yes, how far was the walk?")]
        public int MountainMiles { get; set; }
        [Display(Name ="Are there bikes available?")]
        public bool BikesAvailable { get; set; }
        [Display(Name = "If yes, how many were there available?")]
        public int ManyBikes { get; set; }


    }
}