using StarReverieCore.Mechanics;

namespace StarReverieCore.Models
{
    public class SkillModel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public Skill Skill { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; } = null!;

        public List<WeaponModel> Weapons { get; set; } = new();
    }
}
