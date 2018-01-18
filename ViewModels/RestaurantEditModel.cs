using System;
using Plantvana.Models;
using System.ComponentModel.DataAnnotations;

namespace Plantvana.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
        [Required, MaxLength(80)]
        public string Description { get; set; }
        [Required, MaxLength(500)]
        public string Postcode { get; set; }
        [Required, MaxLength(300)]
        public string Thumbnail { get; set; }
    }
}
