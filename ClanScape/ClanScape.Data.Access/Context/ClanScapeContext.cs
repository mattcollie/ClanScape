using System.Data.Entity;
using ClanScape.Data.Objects.Tables;

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
        }

        public new virtual IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        #endregion

        #region Entities

        public virtual IDbSet<Player> Players { get; set; }
        public virtual IDbSet<SkillType> SkillTypes { get; set; }
        public virtual IDbSet<Skill> Skills { get; set; }
        public virtual IDbSet<Name> Names { get; set; }
        public virtual IDbSet<AdventureLog> AdventureLogs { get; set; }

        #endregion
    }
}
