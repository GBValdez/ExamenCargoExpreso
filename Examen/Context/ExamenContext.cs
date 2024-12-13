using AvionesBackNet.Models;
using Examen.Context.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using project.roles;
using project.users;
namespace Examen.Context
{
    public partial class ExamenContext : IdentityDbContext<userEntity, rolEntity, string>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost:5432;Database=Examen;Username=gbValdez;Password=C0ntr@s3n@");  
        }
        public ExamenContext(DbContextOptions<ExamenContext> options)
        : base(options)
        {
        }

        public ExamenContext() { }

        public DbSet<Brand> brands { get; set; }
        public DbSet<Catalogue> catalogues { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<invoice_detail> invoice_Details { get; set; }

        public DbSet<binnacleHeader> binnacleHeaders { get; set; }
        public DbSet<BinnacleBody> binnacleBody { get; set; }
     }
}
