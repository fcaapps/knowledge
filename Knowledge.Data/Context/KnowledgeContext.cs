using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//using CrudFornec.Data.Extensions;
//using CrudFornec.Data.Mappings;
using Knowledge.Domain.Entities;


namespace Knowledge.Data.Content
{
    public class KnowledgeContext : DbContext
    {
        public KnowledgeContext(DbContextOptions<KnowledgeContext> option)
            : base(option) { }

        #region "DbSets"
        public DbSet<Fornecedor> Fornecedor { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserMap());

            //modelBuilder.ApplyGlobalConfigurations();
            //modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
