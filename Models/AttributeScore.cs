﻿using StarReverieCore.Mechanics;

namespace StarReverieCore.Models
{
    public class AttributeScore
    {
        public int Id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }
        public int MinHP { get; set; }
        public int HP { get; set; }
        public int Will { get; set; }
        public int Perception { get; set; }
        public int MinStamina { get; set; }
        public int Stamina { get; set; }
        public Encumbrance Encumbrance { get; set; }
        public int BasicLift { get; set; }
        public decimal Speed { get; set; }
        public int BasicMove { get; set; }
        public int Dodge { get; set; }
        public int XP { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}