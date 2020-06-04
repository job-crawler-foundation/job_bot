using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBot.Business.Abstractions;
using JobBot.Business.Implementations;
using JobBot.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Telegram.Bot;

namespace JobBot.API
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
            services.AddDbContext<JobBotDbContext>(options =>
            {
            #if (DEBUG)
                options.UseInMemoryDatabase("test");
            #else
                options.UseNpgsql("test");
            #endif
            });

            services.AddSingleton(
                new TelegramBotClient(Environment.GetEnvironmentVariable("TelegramToken")));

            services.AddTransient<ITelegramHookProcessService, TelegramHookProcessService>();

            services.AddTransient<IRegistrationService, RegistrationService>();

            services.AddControllers().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}