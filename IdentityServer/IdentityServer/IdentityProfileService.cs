using IdentityServer4.Services;
using System;
using System.Threading.Tasks;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;
using IdentityServer4.Extensions;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer.Models;

namespace IdentityServer
{
    public class IdentityProfileService : IProfileService
    {
        protected UserManager<ApplicationUser> _userManager;

        public IdentityProfileService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
    
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            // Get the subscriber id
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);

            if(user == null)
                throw new ArgumentException("");
            
            var claims = new List<Claim>
            {
                new Claim("FullName", user.UserName),
                new Claim("Email", user.Email)
            };
    
            context.IssuedClaims.AddRange(claims);
        }
    
        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            context.IsActive = user != null;
        }
    }
}