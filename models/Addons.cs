using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace offertFlyttstad.models
{
    public class Addons
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

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
