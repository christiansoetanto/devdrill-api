using System.Collections.Generic;
using System.Threading.Tasks;
using DevDrillWebAPI.Models;
using DevDrillWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevDrillWebAPI.Controllers
{
    [Route("track")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly TrackService trackService;

        public TrackController(TrackService trackService)
        {
            this.trackService = trackService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTracks()
        {
            List<TrackGroupModel> trackGroups = await trackService.GetTracks();
            return Ok(trackGroups);
        }
    }
}