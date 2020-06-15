using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Mocks;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using SiteOfBlackDesert.Data;
using Microsoft.EntityFrameworkCore;
using SiteOfBlackDesert.Data.Repository;

namespace SiteOfBlackDesert
{
    public class Startup
    {
        private IConfigurationRoot _confSting;

        public Startup(IHostingEnvironment hostEnv) 
        {
            _confSting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddRazorPages();
            services.AddTransient<IAllItems, ItemsRepository>();
            services.AddTransient<ICategoryItems, CategoryItemsRepository>();
            services.AddTransient<ICategoryAlchemyAndCooking, CategoryAlchemyAndCookingRepository>();
            services.AddTransient<IAlchemyAndCooking, AlchemyAndCookingRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseStatusCodePages();
            
            //app.UseMvcWithDefaultRoute();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
