using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DotNetCoreReactREST.Repositories;
using AutoMapper;
using System;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            // Add AutoMapper to map object to object
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<AppDbContext>();
            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;

            }).AddNewtonsoftJson(setupAction =>
            {
                setupAction.SerializerSettings.ContractResolver =
                   new CamelCasePropertyNamesContractResolver();
            })
            //add support for xml
            .AddXmlDataContractSerializerFormatters()
           .ConfigureApiBehaviorOptions(setupAction =>
           {
               //if api modelstate is invalid, add problem details
               setupAction.InvalidModelStateResponseFactory = context =>
               {
                   var problemDetails = new ValidationProblemDetails(context.ModelState)
                   {
                       Type = "",
                       Title = "One or more model validation errors occurred.",
                       Status = StatusCodes.Status422UnprocessableEntity,
                       Detail = "See the errors property for details.",
                       Instance = context.HttpContext.Request.Path
                   };

                   problemDetails.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);

                   return new UnprocessableEntityObjectResult(problemDetails)
                   {
                       ContentTypes = { "application/problem+json" }
                   };
               };
           });
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
