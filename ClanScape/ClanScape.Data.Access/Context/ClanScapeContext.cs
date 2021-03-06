﻿using System.Data.Entity;
using ClanScape.Data.Objects.Tables;
using System.Threading.Tasks;
using System.Linq;
using System;
using ClanScape.Common.BaseEntities;

namespace ClanScape.Data.Access.Context
{
    [DbConfigurationType(typeof(ClanScapeContextConfiguration))]
    public partial class ClanScapeContext : DbContext
    {
        public ClanScapeContext() : base("name=DefaultConnection")  
        {

        }

        #region Overrides

        public static ClanScapeContext Create()
        {
            return new ClanScapeContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().ToTable("Players");
            modelBuilder.Entity<SkillType>().ToTable("SkillTypes");
            modelBuilder.Entity<Skill>().ToTable("Skills");
            modelBuilder.Entity<Name>().ToTable("Names");
            modelBuilder.Entity<AdventureLog>().ToTable("AdventureLogs");
            modelBuilder.Entity<LastProcess>().ToTable("LastProcessed");
        }

        public new virtual IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
        
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {
            foreach (var entity in ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified)))
            {
                DateTime now = DateTime.UtcNow;
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }

        #endregion

        #region Entities

        public virtual IDbSet<Player> Players { get; set; }
        public virtual IDbSet<SkillType> SkillTypes { get; set; }
        public virtual IDbSet<Skill> Skills { get; set; }
        public virtual IDbSet<Name> Names { get; set; }
        public virtual IDbSet<AdventureLog> AdventureLogs { get; set; }
        public virtual IDbSet<LastProcess> LastProcessed { get; set; }        

        #endregion
    }
}
