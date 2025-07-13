namespace StarReverieCore.Mechanics
{
    public class Roll
    {
        private static Random rnd = new Random();

        public static int _3d6() => rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);

        public static int _2d6() => rnd.Next(1, 7) + rnd.Next(1, 7);
          
        public static int _1d6() => rnd.Next(1, 7);
        
    }
}
