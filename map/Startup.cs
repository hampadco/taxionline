using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SignalRChat.Hubs;
using map.Models;

namespace map {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            //////////////////////////////////////////////////////////////////////////startup
            services.AddDbContext<Contextdb> (option => {
                option.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection"));

            });

               services.AddDistributedMemoryCache();

        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(100000000);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });
        services.AddHttpContextAccessor();

       
            services.AddRazorPages ().AddRazorRuntimeCompilation ();
            services.AddControllersWithViews ();
           ///
        
           /// 
           ///  /////////////auto
            services.AddAuthentication (options => {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie (options => {
                options.LoginPath = "/Home/index";
                options.LogoutPath = "/Home/index";
                options.ExpireTimeSpan = TimeSpan.FromMinutes (43200000);
            });
            services.AddSignalR ();
            services.ConfigureApplicationCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromDays(360);
        options.SlidingExpiration = false;
   });
            
           


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                // app.UseExceptionHandler ("/Home/Error");
                // // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // app.UseHsts ();
                 app.UseDeveloperExceptionPage ();
            }
            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseRouting ();
            app.UseAuthentication ();
            app.UseAuthorization ();
            app.UseSession();
            
            

            
            

               

            app.UseEndpoints (endpoints => {

                endpoints.MapAreaControllerRoute (
                    name: "Areas",
                    areaName:"driver",
                    pattern: "driver/{controller=Home}/{action=privacy}/{id?}");

                     endpoints.MapAreaControllerRoute (
                    name: "Areas",
                    areaName:"Admin",
                    pattern: "Admin/{controller=Home}/{action=privacy}/{id?}");


                endpoints.MapControllerRoute (
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}");
                endpoints.MapHub<ChatHub> ("/chathub");
            });
                

        }
    }
}