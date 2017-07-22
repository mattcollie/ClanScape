using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("SkillTypes")]
    public partial class SkillType
    {
        [Key]
        public int Id { get; set; }
        
        public string Type { get; set; }

        public ICollection<Skill> Skills { get; set; }

        public int CalculateCurrentLevel(int currentXP)
        {
            int level = 0;

            switch(Type)
            {
                case "Normal":
                    return Common.Helpers.XPTable.CalculateCurrentNormalLevel(currentXP);
                case "Elite":
                    return Common.Helpers.XPTable.CalculateCurrentEliteLevel(currentXP);
            }

            return level;
        }

        public double CalculatePercentageToLevel(int currentXP)
        {
            double percentage = 1;

            switch (Type)
            {
                case "Normal":
                    return Common.Helpers.XPTable.CalculatePercentageToNormalLevel(currentXP);
                case "Elite":
                    return Common.Helpers.XPTable.CalculatePercentageToEliteLevel(currentXP);
            }

            return percentage;
        }
    }
}
