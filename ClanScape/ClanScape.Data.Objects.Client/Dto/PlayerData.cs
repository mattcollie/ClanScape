using System;
using ClanScape.Data.Objects.Tables;
using System.Collections.Generic;

namespace ClanScape.Data.Objects.Client.Dto
{
    public class PlayerData
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int QuestPoints { get; set; }

        public IList<Skill> Skills { get; set; }
    }
}
