using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SystemAPI.Configuracoes;
using SystemAPI.Configuracoes.Interfaces;
using SystemAPI.Mensagero;
using SystemAPI.Repository;
using SystemAPI.Repository.Interfaces;
using SystemAPI.Service;
using SystemAPI.Service.Interfaces;

namespace SystemAPI
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
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200/",
                                            "https://localhost:4200/");
                    });
            });
            services.AddControllers();

            InjectionDependency(services);
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
            
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void InjectionDependency(IServiceCollection services)
        {
            // basic
            services.AddSingleton<IConfiguracao, Configuracao>();
            services.AddSingleton<IMensageiro, Mensageiro>();
            services.AddSingleton<IClienteService, ClienteService>();
            


            //sql
            services.AddTransient<IRepositoryCliente, RepositoryCliente>();

            //services



        }
    }
}
