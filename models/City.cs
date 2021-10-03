using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace offertFlyttstad.models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public List<Addons> Addons { get; set; }
    }


}
