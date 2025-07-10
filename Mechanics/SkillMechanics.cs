
namespace StarReverieCore.Mechanics
{
    public static class SkillMechanics
    {
        public static int GetSkillCost(int level)
        {

            if (level == 1) return 1;
            if (level == 2) return 2;
            if (level == 3) return 3;

            return 4 + (level - 3) * 4;
        }

        public static int GetAttributeModifier(int level, SkillDifficulty skillDifficulty)
        {

            return skillDifficulty switch
            {
                SkillDifficulty.Easy => level - 1,
                SkillDifficulty.Average => level - 2,
                SkillDifficulty.Hard => level - 3,
                SkillDifficulty.VeryHard => level - 4,
                _ => throw new ArgumentOutOfRangeException(nameof(skillDifficulty), "Invalid difficulty.")
            };
        }

        public static SkillDifficulty GetSkillDifficulty(Skill skill)
        {
            return skill switch
            {
                Skill.Acrobatics => SkillDifficulty.Hard,
                Skill.Armory => SkillDifficulty.Average,
                Skill.Artillery => SkillDifficulty.Average,
                Skill.BallisticWeapons => SkillDifficulty.Easy,
                Skill.ComputerKnowledge => SkillDifficulty.Easy,
                Skill.Diplomacy => SkillDifficulty.Hard,
                Skill.EnergyWeapons => SkillDifficulty.Easy,
                Skill.Engineering => SkillDifficulty.Hard,
                Skill.Explosives => SkillDifficulty.Average,
                Skill.FirstAid => SkillDifficulty.Easy,
                Skill.Gunner => SkillDifficulty.Easy,
                Skill.Leadership => SkillDifficulty.Average,
                Skill.Lockpicking => SkillDifficulty.Average,
                Skill.MartialArts => SkillDifficulty.Average,
                Skill.MeleeWeapons => SkillDifficulty.Average,
                Skill.Merchant => SkillDifficulty.Average,
                Skill.Pickpocket => SkillDifficulty.Hard,
                Skill.Piloting => SkillDifficulty.Average,
                Skill.Science => SkillDifficulty.VeryHard,
                Skill.Stealth => SkillDifficulty.Easy,
                Skill.Throwing => SkillDifficulty.Average,
            };
        }
    }
}
