using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("Skills")]
    public class Skill : ClanScape.Common.BaseEntities.BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public int Rank { get; set; }

        public int CurrentXP { get; set; }

        public int Level { get; set; }

        public DateTime Day { get; set; }

        public Guid PlayerId { get; set; }

        public int SkillTypeId { get; set; }

        [ForeignKey("PlayerId")]
        public virtual Player Player { get; set; }

        [ForeignKey("SkillTypeId")]
        public virtual SkillType SkillType { get; set; }
    }
}
