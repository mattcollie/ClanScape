using ClanScape.Data.Objects.Client.RsDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClanScape.RS.Api.Common.Helpers
{
    public static class Skill
    {
        public static IList<SkillRsDto> ExtractStats(string stats)
        {
            return ExtractSkillData(stats.Split('\n'), skill => skill.Count(c => c == ',') == 2);
        }

        public static IList<SkillRsDto> ExtractSkillData(IList<string> stats, Func<string, bool> skillCallback)
        {
            IList<SkillRsDto> skills = new List<SkillRsDto>();
            foreach(var skill in stats)
                if (skillCallback(skill))
                    skills.Add(ExtractSkill(skills.Count, skill));
            return skills;
        }

        private static SkillRsDto ExtractSkill(int id, string skill)
        {
            return new SkillRsDto
            {
                Id = id,
                Ranking = int.Parse(skill.Split(',')[0]),
                Level = int.Parse(skill.Split(',')[1]),
                CurrentXP = long.Parse(skill.Split(',')[2])
            };
        }
    }
}
