using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Plantvana.Models;
using Plantvana.Services;
using System.Linq;

namespace Plantvana.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ 
                    Id = 1, 
                    Name = "Tofudashi", 
                    Description = "Traditional Japanese food using only plants", 
                    Postcode = "M5 6HJ",
                    Thumbnail = "https://static1.squarespace.com/static/54594723e4b0670d2d3b54f9/t/58838c47ebbd1a30e982cace/1485016139799/Homemade+Vegan+Dumplings+-+by+Madeline+Lu+-+%40lumadeline"
                },
                new Restaurant{ 
                    Id = 2, 
                    Name = "Kentuky Fried Chickpeas", 
                    Description = "Battered and deep fried chickpea mix using the Colonel's secret recipe", 
                    Postcode = "M1 6AE",
                    Thumbnail = "http://www.theedgyveg.com/wp-content/uploads/2015/06/bonafidechicken31.jpg"
                },
                new Restaurant{ 
                    Id = 3, 
                    Name = "La Lentejas", 
                    Description = "Fiery Spanish reciped made from lentils, veg, and other plants", 
                    Postcode = "M3 7NB",
                    Thumbnail = "https://www.archanaskitchen.com//images/archanaskitchen/Mexican_Cuisine/Smoked_Vegetarian_Spanish_Rice_Recipe_Mexican_Rice-1.jpg"
                },
                new Restaurant{
                    Id = 4,
                    Name = "Chickadeepeas",
                    Description = "Everything made from chickpeas",
                    Postcode = "M7 4YU",
                    Thumbnail = "https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe_images/recipe-image-legacy-id--192471_11.jpg"
                }

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Postcode);
        }

        public Restaurant Get (int id )
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add (Restaurant newRestaurant)
        {
            newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        List<Restaurant> _restaurants;
         
    }
}