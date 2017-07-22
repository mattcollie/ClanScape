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

            modelBuilder.Entity<SkillType>().ToTable("SkillTypes");
        }

        public new virtual IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        #endregion

        #region Entities

        public virtual IDbSet<SkillType> SkillTypes { get; set; }

        #endregion
    }
}
