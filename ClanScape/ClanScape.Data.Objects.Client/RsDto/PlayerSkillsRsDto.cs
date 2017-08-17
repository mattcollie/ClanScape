using System.Collections.Generic;

namespace ClanScape.Data.Objects.Client.RsDto
{
    public class PlayerSkillsRsDto
    {
        public string Name { get; set; }

        public int Rank { get; set; }

        public long TotalXp { get; set; }

        public ICollection<SkillRsDto> Skills { get; set; }
    }
}
