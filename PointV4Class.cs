using System;

namespace ValueTypes
{
	class PointV4Class : IEquatable<PointV4Class>
	{
		public int X;
		public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV4Class)) return false;
            PointV4Class other = (PointV4Class)obj;
            return X == other.X && Y == other.Y;
        }

        public bool Equals(PointV4Class other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
