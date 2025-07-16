
namespace StarReverieCore.Grid
{
    public class GridPosition : IEquatable<GridPosition>
    {
        public int x;
        public int y;
        public int z;

        public GridPosition(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override bool Equals(object? obj)
        {
            return obj is GridPosition position &&
                x == position.x &&
                y == position.y &&
                z == position.z;
        }
        public bool Equals(GridPosition other) => this == other;
        public override int GetHashCode() => HashCode.Combine(x, y, z);

        public override string ToString() => $"x: {x}; y: {y}; z: {z}";

        public static bool operator ==(GridPosition a, GridPosition b) =>
            a.x == b.x && a.y == b.y && a.z == b.z;

        public static bool operator !=(GridPosition a, GridPosition b) => !(a == b);

        public static GridPosition operator +(GridPosition a, GridPosition b) =>
            new GridPosition(a.x + b.x, a.y + b.y, a.z + b.z);

        public static GridPosition operator -(GridPosition a, GridPosition b) =>
            new GridPosition(a.x - b.x, a.y - b.y, a.z - b.z);
    }
}
