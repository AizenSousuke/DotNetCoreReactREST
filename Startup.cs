using AutoMapper;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Models;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DotNetCoreReactREST
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
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add Repositories
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            // Add AutoMapper to map object to object
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<AppDbContext>();
            services.AddControllers();
            //Cross Origin Requests
            //AddPolicy("Name of policy")
            services.AddCors(options => options.AddPolicy("AllowOpenOrigin", builder =>
            {

                builder.AllowAnyOrigin()
                      //for specific origins - builder.WithOrigins("http://example.com",
                      //"http://www.contoso.com");
                      .AllowAnyMethod()
                      .AllowAnyHeader();

            }));
            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("AllowOpenOrigin");
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

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
