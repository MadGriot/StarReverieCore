

namespace StarReverieCore.Models
{
    public class SquadModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Character>? Characters { get; set; }
    }
}
