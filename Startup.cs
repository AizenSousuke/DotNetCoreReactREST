using System;
using System.IO;
using AutoMapper;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
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
            // var host = Configuration["DBHOST"] ?? "localhost";
            // var port = Configuration["DBPORT"] ?? "1433";
            // var password = Configuration["DBPASSWORD"] ?? "password";

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
            services.AddScoped<IPostLikeRepository, PostLikeRepository>();

            // Add Business Logic
            services.AddScoped<ICategoryLogic, CategoryLogic>();
            services.AddScoped<ICommentLogic, CommentLogic>();
            services.AddScoped<IPostLikeLogic, PostLikeLogic>();
            services.AddScoped<IPostLogic, PostLogic>();
            services.AddScoped<IPostLikeLogic, PostLikeLogic>();
            services.AddScoped<IUserLogic, UserLogic>();

            // Add AutoMapper to map object to object
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Identity
            services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<AppDbContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            {
                // Password requirements
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireDigit = true;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddRoles<IdentityRole>();
            services.ConfigureApplicationCookie(config =>
            {
                // Set cookie to 5 minutes for dev and 1 day for prod
                if (Environment.IsDevelopment())
                {
                    config.Cookie.MaxAge = new TimeSpan(0, 0, 5, 0, 0);
                }
                else
                {
                    config.Cookie.MaxAge = new TimeSpan(1, 0, 0, 0, 0);
                }

                config.Cookie.Path = "/";
            });
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

            // Add support for xml
            .AddXmlDataContractSerializerFormatters()
            .ConfigureApiBehaviorOptions(setupAction =>
            {
                // If api modelstate is invalid, add problem details
                setupAction.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Type = string.Empty,
                        Title = "One or more model validation errors occurred.",
                        Status = StatusCodes.Status422UnprocessableEntity,
                        Detail = "See the errors property for details.",
                        Instance = context.HttpContext.Request.Path,
                    };

                    problemDetails.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);

                    return new UnprocessableEntityObjectResult(problemDetails)
                    {
                        ContentTypes = { "application/problem+json" },
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
                    Version = "v1",
                });
            });

            // Development directory browser
            services.AddDirectoryBrowser();

            // Authentication
            services.AddAuthentication();

            // Authorization
            services.AddAuthorization();

            // Cross Origin Requests
            // AddPolicy("Name of policy")
            services.AddCors(options => options.AddPolicy("AllowOpenOrigin", builder =>
            {
                // For specific origins - builder.WithOrigins("http://example.com",
                // "http://www.contoso.com");
                builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            }));

            services.AddSpaStaticFiles(configuration =>
            {
                if (Environment.IsDevelopment())
                {
                    configuration.RootPath = "ClientApp/build";
                }
                else
                {
                    // In production, the React files will be served from this directory
                    configuration.RootPath = "wwwroot";
                }
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
                    RequestPath = "/dir",
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

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

            app.UseStaticFiles();

            app.UseSpa(spa =>
            {
                if (env.IsDevelopment())
                {
                    spa.Options.SourcePath = "ClientApp";
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
                else
                {
                    spa.Options.SourcePath = "wwwroot";
                }
            });
        }
    }
}