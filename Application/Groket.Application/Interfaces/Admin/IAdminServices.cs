using Groket.Application.ViewModels.Admin;
using System.Threading.Tasks;

namespace Groket.Application.Interfaces.Admin
{
    /// <summary>
    /// Provider all admin related services
    /// </summary>
    public interface IAdminServices
    {
        /// <summary>
        /// Create a new role
        /// </summary>
        /// <param name="role">role view model</param>
        /// <returns>true/false</returns>
        Task<bool> AddRole(RoleViewModel role);
    }
}
