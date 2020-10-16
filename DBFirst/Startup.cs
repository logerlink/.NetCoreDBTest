using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFirstCore.DB;
using DBFirstService.Impl;
using DBFirstService.IService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DBFirst
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
            //Scaffold-DbContext -f "server=localhost;user id=root;password=123456;persistsecurityinfo=True;database=test" Pomelo.EntityFrameworkCore.MySql -o DB
            var connection = "server=localhost;user id=root;password=123456;persistsecurityinfo=True;database=test";
            services.AddDbContextPool<testContext>(options => options.UseMySql(connection, b => b.MigrationsAssembly("DBTest.DBFirst")));

            //≈‰÷√“¿¿µ◊¢»Î   
            services.AddScoped<IUserService, UserService> ();

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
