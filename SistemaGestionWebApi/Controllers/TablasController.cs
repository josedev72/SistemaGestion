using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionData;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablasController : Controller
    {
        [HttpGet(Name = "GetTablas")]
        public IEnumerable<string> GetTablas()
        {
            return TablasBussiness.GetTablas().ToArray();
        }
    }
}
