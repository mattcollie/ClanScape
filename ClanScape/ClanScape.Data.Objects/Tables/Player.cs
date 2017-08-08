using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("Players")]
    public partial class Player
    {
        [Key]
        public Guid Id { get; set; }
        
        public int QuestPoints { get; set; }
        
        public ICollection<Name> Names { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}
