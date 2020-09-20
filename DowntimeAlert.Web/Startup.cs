using System;
using System.Security.Claims;
using DowntimeAlert.Data.Models;
using DowntimeAlert.Web.Helpers;
using DowntimeAlert.Repo;
using DowntimeAlert.Service.Email;
using DowntimeAlert.Service.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DowntimeAlert.Service.TargetApps;
using DowntimeAlert.Service.AppResponseInfos;

namespace DowntimeAlert.Web
{
    public class Startup
    {
        public static IActivationService ActivationService;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DowntimeAlert;Integrated Security=SSPI")); 
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IActivationService, ActivationService>();
            services.AddScoped<ITargetAppService,TargetAppService>();
            services.AddScoped<IAppResponseInfosService,AppResponseInfosService>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/";
                    options.AccessDeniedPath = "/";
                    options.LogoutPath = "/";
                    options.ExpireTimeSpan = TimeSpan.MaxValue;
                });
            services.AddRouting();
            services.AddMemoryCache();
            services.AddSession();
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                if (!context.Database.EnsureCreated())
                    context.Database.Migrate();
            }
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                //app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            //TEST!
            //app.ApplicationServices.GetService<ITargetAppService>().SetAllTargetAppsSchedule();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }

    }
}
