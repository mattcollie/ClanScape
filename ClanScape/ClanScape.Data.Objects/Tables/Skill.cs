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

        public int SkillTypeId { get; set; }

        [ForeignKey("SkillTypeId")]
        public virtual SkillType SkillType { get; set; }
    }
}
