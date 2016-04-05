using System;

namespace ValueTypes
{
    struct PointV5 : IEquatable<PointV5>
    {
        public int X;
        public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV5)) return false;
            PointV5 other = (PointV5)obj;
            return X == other.X && Y == other.Y;
        }

        public bool Equals(PointV5 other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            int hash = 19;
            hash = hash * 29 + X;
            hash = hash * 29 + Y;
            return hash;
        }
    }
}
