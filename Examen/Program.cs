using Examen.brands;
using Examen.catalogueFIle;
using Examen.Context;
using Examen.Context.Models;
using Examen.products;
using Examen.utils;
using Examen.utils.Components.Menu;
using Examen.utils.FormGeneric;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using project.roles;
using project.users;
using project.utils.services;

namespace Examen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new ServiceCollection();
            configureServices(services);
            using (var serviceProvider = services.BuildServiceProvider()) { 
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
        private static void configureServices(IServiceCollection services)
        {
            services.AddScoped<catalogueView>();
            services.AddScoped<Form1>();
            services.AddScoped<brandsView>();
            services.AddScoped<menuPrincipal>();
            services.AddScoped<productsView>();
            services.AddScoped<interceptorDb>();
            services.AddSingleton<localStorage>();
            services.AddScoped <formGeneric <Catalogue>>();
            services.AddScoped<formGeneric<Product>>();


            services.AddDbContext<ExamenContext>((serviceProvider,options) =>
                options.UseNpgsql("Host=localhost:5432;Database=Examen;Username=gbValdez;Password=C0ntr@s3n@")
                .AddInterceptors(serviceProvider.GetRequiredService<interceptorDb>()));

            services.AddAutoMapper(typeof(autoMapperProfile));
            services.AddIdentityCore<userEntity>()
                .AddRoles<rolEntity>()
                .AddEntityFrameworkStores<ExamenContext>();


            // Registrar las dependencias del formulario
 
        }
    }
}