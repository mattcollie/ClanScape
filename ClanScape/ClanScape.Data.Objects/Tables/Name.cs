using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClanScape.Data.Objects.Tables
{
    [Table("Names")]
    public partial class Name : ClanScape.Common.BaseEntities.BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public string PlayerName { get; set; }

        public Guid PlayerId { get; set; }

        [ForeignKey("PlayerId")]
        public virtual Player Player { get; set; }
    }
}
