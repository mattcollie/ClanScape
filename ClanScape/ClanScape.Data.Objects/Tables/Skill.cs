using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("Skills")]
    public class Skill
    {
        [Key]
        public long Id { get; set; }

        public int CurrentXP { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double PercentageToLevel
        {
            get
            {
                return SkillType.CalculatePercentageToLevel(CurrentXP);
            }
            private set { }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int CurrentLevel
        {
            get
            {
                return SkillType.CalculateCurrentLevel(CurrentXP);
            }
            private set { }
        }
        
        public int SkillTypeId { get; set; }

        [ForeignKey("SkillTypeId")]
        public virtual SkillType SkillType { get; set; }
    }
}
