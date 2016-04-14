using System;

namespace ValueTypes
{
    class PointV5Class : IEquatable<PointV5Class>
    {
        public int X;
        public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV5Class)) return false;
            PointV5Class other = (PointV5Class)obj;
            return X == other.X && Y == other.Y;
        }

        public bool Equals(PointV5Class other)
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
