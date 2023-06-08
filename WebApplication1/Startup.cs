using BusinessLayer.Abstract;
using BusinessLayer.Mapping;
using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Builder;

using Microsoft.EntityFrameworkCore;
using NetixProject1.Controllers;
using System.Configuration;

namespace NetixProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureService(IServiceCollection services)
        {
           services.AddMvc();
            services.AddSession();
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(Startup), typeof(ServiceProfile));
        }
        public void Configure(IApplicationBuilder app,IHostEnvironment env)
        {
            app.UseSession();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Personal}/{action=Index}/{id?}");
            });
        }
    }
}
