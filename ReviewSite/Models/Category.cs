using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }



        // foreign keys and navigation properties
        public virtual ICollection<Review> Reviews { get; set; }

        //[ForeignKey ("Detail"), Display(Name ="Genre")]
        //public int DetailID { get; set; }
        //public virtual Detail Detail { get; set; }
    }
}