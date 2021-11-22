﻿using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData() {
            restaurants = new List<Restaurant>() {
                new Restaurant { Id = 1, Name = "ny212", Cuisine = CuisineType.Frence},
                new Restaurant { Id = 2, Name = "california pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 3, Name = "pizza hut", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 4, Name = "pizza max", Cuisine = CuisineType.Frence},
            };
        }
        IEnumerable<Restaurant> IRestaurantData.GetAll(){
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
