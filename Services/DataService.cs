using offertFlyttstad.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace offertFlyttstad.Services
{
    public class DataService
    {

        public Quote GetOffer(Posts data)
        {
            var addons = new List<Addons>();
            var city = new InitData().Cities.Where(x => x.Id == Convert.ToInt32(data.CityId)).Single();

            if (data.ListAddons != null)
            {
                addons.AddRange(city.Addons.FindAll(x => data.ListAddons.Any(y => y.Id == x.Id)));
            }

            return new Quote
            {
                City = city.Name,
                Size = data.Size,
                Addons = addons,
                Price = Calculate(data.Size, city, data.ListAddons)
            };
        }

        public List<Addons> GetAddons(int id)
        {
            var values = new InitData().Cities.Where(x => x.Id == id).SelectMany(x => x.Addons);

            if (id == 1)
                return values.Where(x => x.Id != 3).ToList();

            return values.ToList();
        }

        private int Calculate(int size, City city, List<Addons> Addons)
        {
            var addonPrice = 0;
            var cityPrice = city.Size;

            foreach (var option in city.Addons)
            {
                if (Addons != null && Addons.Any(x => x.Id == option.Id))
                {
                    addonPrice += city.Addons.Single(x => x.Id == option.Id).Price;
                }
            }

            return size * cityPrice + addonPrice;
        }
    }
}
