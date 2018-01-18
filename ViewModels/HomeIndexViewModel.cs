using System;
using System.Collections.Generic;
using Plantvana.Models;

namespace Plantvana.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public String CurrentMessage { get; set; }
    }
}
