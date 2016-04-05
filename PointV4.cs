using System;

namespace ValueTypes
{
	struct PointV4 : IEquatable<PointV4>
	{
		public int X;
		public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV4)) return false;
            PointV4 other = (PointV4)obj;
            return X == other.X && Y == other.Y;
        }

        public bool Equals(PointV4 other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
