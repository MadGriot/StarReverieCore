using StarReverieCore.Mechanics;

namespace StarReverieCore.Models
{
    public class Character
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public int PowerLevel { get; set; }
        public List<SkillModel> Skills { get; set; } = new();
        public AttributeScore AttributeScore { get; set; }
        public int? WeaponId { get; set; }
        public WeaponModel? Weapon { get; set; }
    }
}
