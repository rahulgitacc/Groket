using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Groket.Application.Interfaces.Admin;
using Groket.Application.Services;
using Groket.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Groket.WebApi.Groket.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GroketContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), optionsBuilder =>
                optionsBuilder.MigrationsAssembly("Groket.Api")));
            services.AddControllers();
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<GroketContext>();
            // configure bearer scheme to authenticate the api 
            services.AddAuthentication("Bearer")
                .AddJwtBearer(option => {
                    option.Authority = "http://localhost:5000";
                    option.RequireHttpsMetadata = false;
                    option.Audience = "groketApi";
                });
            //services.AddSingleton(typeof(IAdminServices));
            services.AddScoped<IAdminServices, AdminServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
