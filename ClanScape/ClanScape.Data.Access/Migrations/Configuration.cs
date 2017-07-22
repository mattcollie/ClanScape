using System.Data.Entity.Migrations;
using ClanScape.Data.Access.Context;
using ClanScape.Data.Objects.Tables;

namespace ClanScape.Data.Access.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ClanScapeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        private ClanScapeContext Context { get; set; }

        protected override void Seed(ClanScapeContext context)
        {
            Context = context;
            SeedSkillTypes();
            Context.SaveChanges();
        }

        #region Seeds

        private void SeedSkillTypes()
        {
            Context.SkillTypes.Add(new SkillType { Id = 0, Type = "Normal" });
            Context.SkillTypes.Add(new SkillType { Id = 1, Type = "Elite" });
        }

        #endregion
    }
}
