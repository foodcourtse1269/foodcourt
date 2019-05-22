using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAdmin.Config;
using WebAdmin.Config.Mappings;
using WebAdmin.Models;
using WebAdmin.Repositories;
using WebAdmin.Services;

namespace WebAdmin
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "clientapp/build";
            });
            services.AddSingleton(Configuration.GetSection("MyConfiguration").Get<MyConfiguration>());
            services.AddDbContext<FoodCourtContext>(
                options => options.UseSqlServer("Server=.;Database=foodcourt;User ID=sa;Password=12345678;"));
            this.addScopedForRepo(services);
            this.addScopedForService(services);
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ModelToDtoProfile());
                mc.AddProfile(new DtoToModelProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            // End auto mapper configurations
        }

        private void addScopedForRepo(IServiceCollection services)
        {
            services.AddScoped<CategoryRepository, CategoryRepository>();
            services.AddScoped<CustomerRepository, CustomerRepository>();
            services.AddScoped<EmployeeRepository, EmployeeRepository>();
            services.AddScoped<FoodRepository, FoodRepository>();
            services.AddScoped<OrderRepository, OrderRepository>();
            services.AddScoped<OrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<OrderStoreRepository, OrderStoreRepository>();
            services.AddScoped<RoleRepository, RoleRepository>();
            services.AddScoped<StoreRepository, StoreRepository>();
            services.AddScoped<TransactionRepository, TransactionRepository>();
            services.AddScoped<TransactionTypeRepository, TransactionTypeRepository>();
        }

        private void addScopedForService(IServiceCollection services)
        {
            services.AddScoped<IRoleService, RoleService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "clientapp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
