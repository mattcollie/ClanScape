using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("Players")]
    public partial class Player : ClanScape.Common.BaseEntities.BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        public int QuestPoints { get; set; }

        public int Rank { get; set; }

        public long TotalXp { get; set; }
        
        public ICollection<Name> Names { get; set; }

        public ICollection<Skill> Skills { get; set; }

        public ICollection<AdventureLog> AdventureLogs { get; set; }
    }
}
