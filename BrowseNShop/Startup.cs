using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrowseNShop.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BrowseNShop.Interfaces;
using BrowseNShop.Mocks;
using BrowseNShop.Data.Repositories;
using BrowseNShop.Models;
using Microsoft.Extensions.Logging;
using BrowseNShop.Data.Models;
using BrowseNShop.Data.Interfaces;

namespace BrowseNShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    //Server configuration
        //    services.AddDbContext<ApplicationDbContext>(options =>
        //        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        //    //Authentication, Identity config
        //    services.AddIdentity<IdentityUser, IdentityRole>()
        //        .AddEntityFrameworkStores<ApplicationDbContext>();

        //    services.AddTransient<ICategoryRepository, CategoryRepository>();
        //    services.AddTransient<ISneakerRepository, SneakerRepository>();



        //    services.AddMvc();
        //    services.AddMemoryCache();
        //    services.AddSession();
        //}


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /**/
            services.AddTransient<ISneakerRepository, SneakerRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));

            services.AddTransient<IOrderRepository, OrderRepository>();


            services.AddSession();
            services.Configure<CookiePolicyOptions>(options =>
            {
                //This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            
            app.UseCookiePolicy();

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
           // app.UseMvcWithDefaultRoute();

            DbInitializer.Seed(serviceProvider);

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "categoryFilter", 
                    template: "Sneaker/{action}/{category?}",defaults: new { Controller="Sneaker", action="List"});



                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            


            
        }
    }
}
