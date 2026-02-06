using Microsoft.AspNetCore.Mvc;
using RIN.Core;
using RIN.WebAPI.Utils;

namespace RIN.WebAPI.Controllers
{
    [ApiController]
    [Route("Clientapi/api/v4")]
    [Produces("application/json")]
    [ProducesErrorResponseType(typeof(Error))]
    public class ClientApiV4 : TmwController
    {
        [HttpGet("dashboard/conductor-assets")]
        [R5SigAuthRequired]
        public async Task<object> DashboardConductorAssets()
        {
            return Content("[]", "application/json");
        }

        [HttpGet("dashboard/conductor-events")]
        [R5SigAuthRequired]
        public async Task<object> DashboardConductorEvents()
        {
            return Content("[]", "application/json");
        }
    }
}
