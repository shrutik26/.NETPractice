using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Model;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Data.Services;

namespace WebApplication2
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

            services.AddControllers();

            //ConnectionString
            var connectionString = Configuration.GetSection("ConnectionStrings:DefaultConnectionString").Value;
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

            //Service
            services.AddTransient<EmployeeService>();
            services.AddTransient<DepartmentService>();
            services.AddTransient<ProductService>();
            services.AddTransient<LogService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication2", Version = "v1" });
            });


            services.AddMassTransit(configure => {
                configure.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host("localhost", "/", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });
                    cfg.ExchangeType = ExchangeType.Direct;
                });

            });
            services.AddMassTransitHostedService(true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplication2 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            var bus = Bus.Factory.CreateUsingRabbitMq(configure =>
            {

                configure.Publish<Order>(x =>
                {
                    x.Durable = false; 
                    x.AutoDelete = true; 
                    x.ExchangeType = "direct";

                });

                configure.Publish<Order>(x =>
                {
                    x.Exclude = true; 
                });
            });

            AppDbInitializer.Seed(app);

            bus.Start();
            bus.Publish(new Order { Name = "Shrutik Deshmukh is my name" });
        }
    }
}
