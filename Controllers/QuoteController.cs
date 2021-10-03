using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;

using offertFlyttstad.models;
using offertFlyttstad.Services;

namespace offertFlyttstad.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly DataService _dataService;

        public QuoteController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public InitData Get() => new InitData();

        [HttpPost]
        public Quote Save([FromBody] Posts data) => _dataService.GetOffer(data);

        [HttpGet]
        [Route("getAddons/{id}")]
        public List<Addons> GetOptions(int id) => _dataService.GetAddons(id);
    }


}
