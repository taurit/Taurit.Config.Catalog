using System;
using Microsoft.AspNetCore.Mvc;
using Taurit.Config.Catalog.Models.HealthyMealPlanner;

namespace Taurit.Config.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthyMealPlannerController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("CurrentVersion")]
        public ActionResult<SoftwareVersionInformation> Get()
        {
            // mock
            var currentVersion = new SoftwareVersionInformation(new Version(0, 0, 1));
            return currentVersion;
        }
    }
}