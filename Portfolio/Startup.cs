using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Contact",
                    pattern: "Contact",
                    defaults: new { controller = "Contact", action = "Contact" }
                    );
                endpoints.MapControllerRoute(
                    name: "Exp",
                    pattern: "Experiences_professionnelles",
                    defaults: new { controller = "Experiences", action = "ExperiencesPro" }
                    );
                endpoints.MapControllerRoute(
                    name: "Formations",
                    pattern: "Formations",
                    defaults: new { controller = "Experiences", action = "Formations" }
                    );

                endpoints.MapControllerRoute(
                    name: "TicketCine",
                    pattern: "Realisations/TicketCinema",
                    defaults: new { controller = "Home", action = "TicketCine" }
                    );

                endpoints.MapControllerRoute(
                    name: "AvisFormation",
                    pattern: "Realisations/AvisFormation",
                    defaults: new { controller = "Home", action = "AvisFormation" }
                    );

                endpoints.MapControllerRoute(
                    name: "SimplyOrNot",
                    pattern: "Realisations/SimplyOrNot",
                    defaults: new { controller = "Home", action = "SimplyOrNot" }
                    );

                endpoints.MapControllerRoute(
                    name: "CodeIgniter",
                    pattern: "Realisations/CodeIgniter",
                    defaults: new { controller = "Home", action = "CodeIgniter" }
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
