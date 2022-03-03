using Application.Features.MaterialGroups.Dtos;
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
    public class MssqlDbContext : BaseDbContext
    {
        protected IConfiguration Configuration { get; set; }

        public MssqlDbContext(DbContextOptions<MssqlDbContext> dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;

        }

        public MssqlDbContext()
        {


        }

        public DbSet<VW_ExceptionRuleByLineModel> VW_ExceptionRuleByLineModel { get; set; }
        public DbSet<VW_GeneralRuleByLine> VW_GeneralRuleByLine { get; set; }
        public DbSet<VW_MatchCount_byLineModel> VW_MatchCount_byLineModel { get; set; }
        public DbSet<MaterialGroup> MaterialGroup { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Tablodan veri çekmek için
            modelBuilder.Entity<MaterialGroup>(m =>
            {
                m.ToTable("MaterialGroup", "trace").HasKey(k => k.Id);
                m.Property(m => m.Id).HasColumnName("Id");
                m.Property(m => m.Name).HasColumnName("Name");
                #region OTHER PROPS
                //m.Property(m => m.BarcodeDefinitionId).HasColumnName("BarcodeDefinitionId");
                //m.Property(m => m.BomCheckActive).HasColumnName("BomCheckActive");
                //m.Property(m => m.Code).HasColumnName("Code");
                //m.Property(m => m.CreateDateTime).HasColumnName("CreateDateTime");
                //m.Property(m => m.CreatedBy).HasColumnName("CreatedBy");
                //m.Property(m => m.isActive).HasColumnName("isActive");
                //m.Property(m => m.isDeleted).HasColumnName("isDeleted");
                //m.Property(m => m.UpdateDateTime).HasColumnName("UpdateDateTime");
                //m.Property(m => m.UpdatedBy).HasColumnName("UpdatedBy"); 
                #endregion


            });

            //}).HasDefaultSchema("trace");

            //Viewden veri çekmek için
            modelBuilder.Entity<VW_ExceptionRuleByLineModel>()
                .ToView(nameof(VW_ExceptionRuleByLineModel));

            modelBuilder.Entity<VW_GeneralRuleByLine>()
                .ToView(nameof(VW_GeneralRuleByLine));     
            
            modelBuilder.Entity<VW_MatchCount_byLineModel>()
                .ToView(nameof(VW_MatchCount_byLineModel));


            
        }

    }
}
