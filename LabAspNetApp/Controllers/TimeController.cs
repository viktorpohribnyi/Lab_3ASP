using LabAspNetApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace LabAspNetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly TimeService _timeService;

        public TimeController(TimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpGet]
        public IActionResult GetTimeOfDay()
        {
            var timeOfDay = _timeService.GetTimeOfDay();
            return Ok(timeOfDay);
        }
    }
}
