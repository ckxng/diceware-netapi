using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenTelemetry.Trace;
using System.Diagnostics;

namespace diceware_netapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Program.DicewareActivitySource = new ActivitySource(
                Configuration.GetValue<string>("ActivitySourceName"));

            services.AddOpenTelemetryTracing(
                (builder) => builder
                    .AddAspNetCoreInstrumentation()
                    .AddSource(Configuration.GetValue<string>("ActivitySourceName"))
                    .AddJaegerExporter()
                );

            services.AddSingleton<Service.IDiceRollerService, Service.DiceRollerService>();

            services.AddControllers();

            services.AddDbContext<Models.WordlistDBContext>(
                options => options.UseSqlite(Configuration.GetConnectionString("WordlistDBContext")));
        }
    }
}