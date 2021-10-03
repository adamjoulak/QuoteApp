using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace offertFlyttstad.models
{
    public class InitData
    {
        public List<City> Cities => SetCities();

        private List<City> SetCities()
        {
            return new List<City>
            {
                new City { Id = 1, Name = "Stockholm", Size = 65, Addons = GetAddons() },
                new City { Id = 2, Name = "Uppsala", Size = 55, Addons = GetAddons()}
            };
        }

        private List<Addons> GetAddons()
        {
            return new List<Addons>
            {
                new Addons { Id = 1, Name = "Fönsterputs", Price = 300},
                new Addons { Id = 2, Name = "Balkongstädning", Price = 150},
                new Addons { Id = 3, Name = "Bortforsling av skräp", Price = 400}
            };
        }
    }
}
