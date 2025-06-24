namespace StarReverieCore.Models
{
    public class Character
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public int Level { get; set; }
        public int PowerLevel { get; set; }
    }
}
