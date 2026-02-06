using Microsoft.AspNetCore.Mvc;

namespace RIN.WebAPI.Controllers
{
    [ApiController]
    public class IngameController : TmwController
    {
        [HttpGet("/ingame/panelmanager")]
        public async Task<object> PanelManager()
        {
            return Content("{}", "application/json");
        }
    }
}
