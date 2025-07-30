
using StarReverieCore.Mechanics;

namespace StarReverieCore.Models
{
    public abstract class Unit
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Skill Skill { get; set; }
        public List<Character>? Characters { get; set; }
    }
}
