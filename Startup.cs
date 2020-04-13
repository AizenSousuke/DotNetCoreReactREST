using AutoMapper;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;

namespace DotNetCoreReactREST
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuration variables
            //var host = Configuration["DBHOST"] ?? "localhost";
            //var port = Configuration["DBPORT"] ?? "1433";
            //var password = Configuration["DBPASSWORD"] ?? "password";

            if (Environment.IsDevelopment())
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            }
            else
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ProductionConnection")));
            }

            // Add Repositories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();

            // Add AutoMapper to map object to object
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Identity
            services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<AppDbContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            {
                // Password requirements
                opt.Password.RequiredLength = 8;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddRoles<IdentityRole>();
            services.AddScoped<UserManager<ApplicationUser>>();
            services.AddScoped<SignInManager<ApplicationUser>>();

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

            // Swashbuckle
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Blog API",
                    Description = "All the endpoints documentation.",
                    Version = "v1"
                });
            });

            // Development directory browser
            services.AddDirectoryBrowser();

            // Authentication
            services.AddAuthentication();

            // Authorization            
            services.AddAuthorization();

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
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext appDbContext)
        {
            // Migrate the database if it is not already created (for docker use)
            appDbContext.Database.Migrate();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("AllowOpenOrigin");

                // Development only directory browsing
                app.UseDirectoryBrowser(new DirectoryBrowserOptions()
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory())),
                    RequestPath = "/dir"
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Temporarily disable https for prod
            if (env.IsDevelopment())
            {
                app.UseHttpsRedirection();
            }

            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                // In development, the React files will be served from this directory
                app.UseSpaStaticFiles(new StaticFileOptions()
                {
                    DefaultContentType = "application/json",
                    RequestPath = "/ClientApp/build"
                });
            }
            else
            {
                // In production, the React files will be served from this directory
                app.UseSpaStaticFiles(new StaticFileOptions
                {
                    DefaultContentType = "application/json",
                    RequestPath = "/wwwroot"
                });
            }

            // Swashbuckle Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog API v1");
                // To serve the Swagger UI at the app's root (http://localhost:<port>/), set the RoutePrefix property to an empty string:
                // c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            // Use authentication and authorization - who are you vs are you allowed
            app.UseAuthentication();
            app.UseAuthorization();

            // Automatically add required content-type headers in case client forgot about it or used the text/plain, for example
            app.Use(async (context, nextMiddleware) =>
            {
                // Remove existing headers and add the required ones
                context.Request.Headers.Remove("Content-Type");
                context.Request.Headers.Add("Content-Type", "application/json");
                await nextMiddleware();
            });

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
