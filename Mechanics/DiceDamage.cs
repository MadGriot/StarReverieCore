namespace StarReverieCore.Mechanics
{
    public class DiceDamage
    {
        public int DiceCount { get; set; }
        public int Modifier { get; set; }

        public DiceDamage(int diceCount, int modifier)
        {
            DiceCount = diceCount;
            Modifier = modifier;
        }

        public int Roll(Random rng)
        {
            int total = 0;
            for (int i = 0; i < DiceCount; i++)
                total += rng.Next(1, 7);
            return total + Modifier;
        }

        public override string ToString()
        {
            string mod = Modifier switch
            {
                > 0 => $"+{Modifier}",
                < 0 => $"{Modifier}",
                _ => ""
            };
            return $"{DiceCount}d{mod}";
        }
    }
}
