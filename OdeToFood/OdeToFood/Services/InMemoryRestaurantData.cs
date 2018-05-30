using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurantData :IRestaurantData
    //{
    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant{ Id = 1, Name = "Trattoria"},
    //            new Restaurant{ Id = 2, Name = "Urfa"},
    //            new Restaurant{ Id=3, Name="Sevi"}
    //        };
    //    }
    //    List<Restaurant> _restaurants;

    //    public IEnumerable<Restaurant> getAll()
    //    {
    //        return _restaurants.OrderBy(r => r.Name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(restaurant);
    //        return restaurant;
    //    }

    //    public Restaurant Update(Restaurant restaurant)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
