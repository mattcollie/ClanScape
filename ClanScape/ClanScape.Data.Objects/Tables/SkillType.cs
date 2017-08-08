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
    }
}
