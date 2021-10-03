using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace offertFlyttstad.models
{
    public class Quote
    {
        public string City { get; set; }
        public int Size { get; set; }
        public List<Addons> Addons { get; set; }
        public int Price { get; set; }

    }
}
