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
            Context.SkillTypes.Add(new SkillType { Id = 1, Type = "Normal", Style = "Combat", Name = "Attack" });
            Context.SkillTypes.Add(new SkillType { Id = 2, Type = "Normal", Style = "Combat", Name = "Strength" });
            Context.SkillTypes.Add(new SkillType { Id = 3, Type = "Normal", Style = "Combat", Name = "Defence" });
            Context.SkillTypes.Add(new SkillType { Id = 4, Type = "Normal", Style = "Combat", Name = "Ranged" });
            Context.SkillTypes.Add(new SkillType { Id = 5, Type = "Normal", Style = "Combat", Name = "Prayer" });
            Context.SkillTypes.Add(new SkillType { Id = 6, Type = "Normal", Style = "Combat", Name = "Magic" });
            Context.SkillTypes.Add(new SkillType { Id = 7, Type = "Normal", Style = "Combat", Name = "Constitution" });
            Context.SkillTypes.Add(new SkillType { Id = 8, Type = "Normal", Style = "Combat", Name = "Summoning" });
            Context.SkillTypes.Add(new SkillType { Id = 9, Type = "Normal", Style = "Gathering", Name = "Mining" });
            Context.SkillTypes.Add(new SkillType { Id = 10, Type = "Normal", Style = "Gathering", Name = "Fishing" });
            Context.SkillTypes.Add(new SkillType { Id = 11, Type = "Normal", Style = "Gathering", Name = "Woodcutting" });
            Context.SkillTypes.Add(new SkillType { Id = 12, Type = "Normal", Style = "Gathering", Name = "Farming" });
            Context.SkillTypes.Add(new SkillType { Id = 13, Type = "Normal", Style = "Gathering", Name = "Hunter" });
            Context.SkillTypes.Add(new SkillType { Id = 14, Type = "Normal", Style = "Gathering", Name = "Divination" });
            Context.SkillTypes.Add(new SkillType { Id = 15, Type = "Normal", Style = "Artisan", Name = "Herblore" });
            Context.SkillTypes.Add(new SkillType { Id = 16, Type = "Normal", Style = "Artisan", Name = "Crafting" });
            Context.SkillTypes.Add(new SkillType { Id = 17, Type = "Normal", Style = "Artisan", Name = "Fletching" });
            Context.SkillTypes.Add(new SkillType { Id = 18, Type = "Normal", Style = "Artisan", Name = "Smithing" });
            Context.SkillTypes.Add(new SkillType { Id = 19, Type = "Normal", Style = "Artisan", Name = "Cooking" });
            Context.SkillTypes.Add(new SkillType { Id = 20, Type = "Normal", Style = "Artisan", Name = "Firemaking" });
            Context.SkillTypes.Add(new SkillType { Id = 21, Type = "Normal", Style = "Artisan", Name = "Runecrafting" });
            Context.SkillTypes.Add(new SkillType { Id = 22, Type = "Normal", Style = "Artisan", Name = "Construction" });
            Context.SkillTypes.Add(new SkillType { Id = 23, Type = "Normal", Style = "Support", Name = "Agility" });
            Context.SkillTypes.Add(new SkillType { Id = 24, Type = "Normal", Style = "Support", Name = "Thieving" });
            Context.SkillTypes.Add(new SkillType { Id = 25, Type = "Master", Style = "Support", Name = "Slayer" });
            Context.SkillTypes.Add(new SkillType { Id = 26, Type = "Master", Style = "Support", Name = "Dungeoneering" });
            Context.SkillTypes.Add(new SkillType { Id = 27, Type = "Elite", Style = "Skilling", Name = "Invention" });
        }

        #endregion
    }
}
