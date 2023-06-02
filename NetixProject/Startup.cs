using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using NetixProject.Controlles;

namespace NetixProject
{
    public class Startup
    {
        public void ConfigureService(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
            
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
