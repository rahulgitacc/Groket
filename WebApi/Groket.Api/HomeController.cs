using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Groket.Application.ViewModels.Admin;
using Groket.Application.Interfaces.Admin;
using System.Threading.Tasks;

namespace Groket.Api
{
    [Route("api/Home")]
    public class HomeController : ControllerBase
    {
        private IAdminServices _adminServices;

        public HomeController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }
        public async Task<IActionResult> Get()
        {
            //var a = User.Identity.Name;
            //return new JsonResult(from c in User.Claims select new { c.Type, c.Value, a });
            try
            {
                var model = new RoleViewModel();
                model.RoleName = "Admin";
                if (ModelState.IsValid)
                {
                    var result = await _adminServices.AddRole(model);
                    return new JsonResult(result);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
            
        }
    }
}
