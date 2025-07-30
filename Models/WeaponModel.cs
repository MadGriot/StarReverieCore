using StarReverieCore.Equipment;

namespace StarReverieCore.Models
{
    public class WeaponModel : Unit
    {
        public required WeaponType WeaponType { get; set; }
        public required DamageType DamageType { get; set; }
        public WeaponClass WeaponClass { get; set; }
        public int DiceCount { get; set; }
        public int Modifier { get; set; }
        public int Accuracy { get; set; }
        public int Range { get; set; }
        public decimal WeaponWeight { get; set; }
        public decimal AmmoWeight { get; set; }
        public int RoF { get; set; }
        public int MaxAmmo { get; set; }
        public int CurrentAmmo { get; set; }
        public int STRRequirement { get; set; }
        public int Bulk { get; set; }
        public decimal Cost { get; set; }

    }
}
