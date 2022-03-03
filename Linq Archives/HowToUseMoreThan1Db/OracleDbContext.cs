using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class OracleDbContext : BaseDbContext
    {
        protected IConfiguration Configuration { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;

        }

        public OracleDbContext()
        {


        }

        public DbSet<BarcodeProduction> BarcodeProductions { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<BarcodeProduction>(m =>
            {
                m.ToTable("RFC_BARCODE_PRODUCTION");
                m.Property(m => m.Line).HasColumnName("LINE");
                m.Property(m => m.Material).HasColumnName("MATERIAL");
                m.Property(m => m.ProdDate).HasColumnName("PRODDATE");
                //m.Property(m => m.BarcodeProductionCount).HasColumnName("BarcodeProductionCount");


            });

        }
    }
}
