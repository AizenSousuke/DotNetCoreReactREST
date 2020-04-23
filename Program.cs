using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using System;

namespace DotNetCoreReactREST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Add Serilog for logging through new configuration before the CreateHostBuilder function.
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // Change the date format here
            string date = DateTime.Now.ToString("ddMMyyyyHHmm");
            // Change the filename here
            string logfile = String.Concat("Logs/logfile_" + date + ".log");

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .WriteTo.Console(
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} UTC [{Level}] {Message}{NewLine}{Exception}")
                .WriteTo.File(new CompactJsonFormatter(), logfile)
                .CreateLogger();

            Log.Information("Added logging to Program.cs before CreateHostBuilder so can log the try catch.");

            try
            {
                Log.Information("Application starting up on {MachineName}");

                // Create host
                var host = CreateHostBuilder(args)
                    .Build();

                // run the web app
                host.Run();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application failed to even run.");
                throw;
            }
            finally
            {
                // Make sure the log is closed correctly
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog() // <-- Add this line for serilog;
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Set defaults here

                    // If Environment is Production
                    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
                    {
                        IConfigurationRoot configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.Production.json")
                        .Build();
                        webBuilder.UseConfiguration(configuration);
                    }
                    webBuilder.UseStartup<Startup>();
                });
    }
}
