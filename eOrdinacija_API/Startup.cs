using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eOrdinacija_API.Database;
using eOrdinacija_API.Exceptions;
using eOrdinacija_API.Filters;
using eOrdinacija_API.Security;
using eOrdinacija_API.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace eOrdinacija_API
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
            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAutoMapper();
            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eOrdinacija API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddScoped<IZaposlenikService, ZaposlenikService>();
            services.AddScoped<IUlogaService, UlogaService>();
            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<INabavkaService, NabavkaService>();
            services.AddScoped<INabavkaMaterijalService, NabavkaMaterijalService>();
            services.AddScoped<IStomatoloskiMaterijalService,StomatoloskiMaterijalService>();
            services.AddScoped<ILijekService, LijekService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();
            services.AddScoped<IUslugaService, UslugaService>();
            services.AddScoped<IPregledService, PregledService>();
            services.AddScoped<IReceptService, ReceptService>();
            services.AddScoped<IUslugaMaterijalService, UslugaMaterijalService>();
            services.AddScoped<IOcjenaService, OcjenaService>();

            var connection = Configuration.GetConnectionString("eOrdinacija");
            services.AddDbContext<eOrdinacijaContext>(options => options.UseSqlServer(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
