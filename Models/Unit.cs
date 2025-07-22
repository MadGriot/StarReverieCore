
namespace StarReverieCore.Models
{
    public abstract class Unit
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int SkillId { get; set; }
        public SkillModel? SkillModel { get; set; }
    }
}
