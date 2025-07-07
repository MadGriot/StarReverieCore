using StarReverieCore.Mechanics;

namespace StarReverieCore.Models
{
    public class SkillModel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public SkillDifficulty SkillDifficulty { get; set; }
        public Skill Skill { get; set; }

    }
}
