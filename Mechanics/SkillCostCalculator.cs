using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarReverieCore.Mechanics
{
    public static class SkillCostCalculator
    {
        public static int GetSkillCost(SkillDifficulty difficulty, int level)
        {
            switch (difficulty)
            {
                case SkillDifficulty.Easy:

                    return(1 * level);
                case SkillDifficulty.Average:
                    break;
                case SkillDifficulty.Hard:
                    break;
                case SkillDifficulty.VeryHard:
                    break;
            }
            return 0;
        }
    }
}
