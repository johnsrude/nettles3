using AutoMapper;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NettlesApi.Models;
using NettlesLibrary.ViewModels; // TODO: Bug in VS 2015 and APS.NET 5 prevents this from being referenced.

namespace NettlesApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<NettlesContext>(
                    options => { options.UseSqlServer(Configuration["Data:ConnectionString"]); });
            services.AddScoped<INettlesRepository, NettlesRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseMvc();

            // AutoMapper
            Mapper.Initialize(i => i.CreateMap< Show, ShowViewModel>());

            // Test Data
            SampleData.Initialize(app.ApplicationServices);
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
