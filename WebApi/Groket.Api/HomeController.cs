using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Groket.Api
{
    [Route("api/Home")]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            var a = User.Identity.Name;
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value, a });
        }
    }
}
