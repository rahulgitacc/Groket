
using System.ComponentModel.DataAnnotations;

namespace Groket.Application.ViewModels.Admin
{
    /// <summary>
    /// Get or Set the role entity
    /// </summary>
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
