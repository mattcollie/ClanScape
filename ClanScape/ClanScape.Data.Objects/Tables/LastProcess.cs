using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("LastProcesses")]
    public partial class LastProcess
    {
        [Key]
        public Guid Id { get; set; }
        
        public DateTime Skill { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid PlayerId { get; set; }

        [ForeignKey("PlayerId")]
        public virtual Player Player { get; set; }
    }
}
