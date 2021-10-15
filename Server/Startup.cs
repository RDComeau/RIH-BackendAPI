using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using RIH_GameLogic.Services.VersionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using RIH_GameLogic.Repo.VersionOne;
using RIH_GameLogic.Helpers.Interfaces;
using RIH_GameLogic.Helpers;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;

namespace Server
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
            //Game Session
            services.AddSingleton<IGameSessionServiceV1, GameSessionServiceV1>();
            services.AddSingleton<IGameSessionRepoV1, GameSessionRepoV1>();
            //Cabal
            services.AddSingleton<ICabalServiceV1, CabalServiceV1>();
            services.AddSingleton<ICabalRepoV1, CabalRepoV1>();
            //Units Information
            services.AddSingleton<IUnitsInformationServiceV1, UnitsInformationServiceV1>();
            //Helpers
            services.AddSingleton<IConfigHelper, ConfigHelper>();

            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "RIH API",
                    Description = "The RIH API for the tabletop game",
                    TermsOfService = new Uri("https://example.com/terms")
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RIH API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
