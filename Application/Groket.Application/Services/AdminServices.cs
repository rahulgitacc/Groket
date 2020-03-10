using Groket.Application.Interfaces.Admin;
using Groket.Application.ViewModels.Admin;
using Groket.Data;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Groket.Application.Services
{
    public class AdminServices : IAdminServices
    {
        private RoleManager<IdentityRole> _roleManager;
        private GroketContext _context;

        public AdminServices(RoleManager<IdentityRole> roleManager, GroketContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        /// <summary>
        /// Create a new role
        /// </summary>
        /// <param name="role">role view model</param>
        /// <returns>true/false</returns>
        public async Task<bool> AddRole(RoleViewModel role)
        {
            try
            {
                var result = await _roleManager.CreateAsync(new IdentityRole { Name = role.RoleName });
                return result.Succeeded ? true : false;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
    }
}
