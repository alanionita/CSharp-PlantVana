using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Plantvana.Models;
using System.Linq;

namespace Plantvana.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant>GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}