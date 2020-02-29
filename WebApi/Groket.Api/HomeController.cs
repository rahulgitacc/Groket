using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Groket.Api
{
    [Route("api/Home")]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
