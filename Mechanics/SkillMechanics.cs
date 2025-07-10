
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
    }
}
