using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Associado Controller",
                    Description = "Controller para gerenciamento das informações do associado",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                });
            });
            //  services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //services.AddSwaggerGen(options =>
            //{
            //    options.SwaggerDoc("v1",
            //        new OpenApiInfo
            //        {
            //            Title = "Associado Controller"
            //        });
            //});
            // var applicationBasePath = // PlatformServices.Default.Application.ApplicationBasePath;//\WebApplication1\WebApplication1\WebApplication1.xml
            // var applicationName = PlatformServices.Default.Application.ApplicationName;
            // var xmlDocumentPath = Path.Combine(applicationBasePath, $"{applicationName}.xml");

            //if (File.Exists(xmlDocumentPath))
            //    {
            //        options.IncludeXmlComments(xmlDocumentPath);
            //    }
            //});


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }
        }
    }
}
