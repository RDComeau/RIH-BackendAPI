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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
