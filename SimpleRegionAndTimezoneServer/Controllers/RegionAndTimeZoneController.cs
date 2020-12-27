using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace SimpleRegionAndTimezoneServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionAndTimeZoneController : ControllerBase
    {
       
        private readonly ILogger<RegionAndTimeZoneController> _logger;

        public RegionAndTimeZoneController(ILogger<RegionAndTimeZoneController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public SimpleRegionAndTimezoneServer.RegionAndTimeZone Get()
        {
            var regionTimezoneData = new SimpleRegionAndTimezoneServer.RegionAndTimeZone  //namespace WebApplication4; public class RegionAndTimezone
            {
                Region = RegionInfo.CurrentRegion,
                Timezoneinfo = TimeZoneInfo.Local,
            };

            return regionTimezoneData;
        }
    }
}
