using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Plantvana.Models 
{
    public class Restaurant 
    {
        public int Id { get; set; }

        [Display(Name = "Restaurant Name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set;}
        public string Description { get; set; }
        public string Postcode { get; set; }
        public string Thumbnail { get; set; }
    }
}