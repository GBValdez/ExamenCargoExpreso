using Examen.Context;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using project.roles;
using project.users;

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
            services.AddDbContext<ExamenContext>(options =>
                options.UseNpgsql("Host=localhost:5432;Database=Examen;Username=gbValdez;Password=C0ntr@s3n@"));

            services.AddIdentityCore<userEntity>()
                .AddRoles<rolEntity>()
                .AddEntityFrameworkStores<ExamenContext>();


            // Registrar las dependencias del formulario
            services.AddScoped<Form1>();

        }
    }
}