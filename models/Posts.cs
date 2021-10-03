using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace offertFlyttstad.models
{
    public class Posts
    {
        public string CityId { get; set; }
        public int Size { get; set; }
        public List<Addons> ListAddons { get; set; }
    }
}
