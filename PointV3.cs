using System;

namespace ValueTypes
{
	struct PointV3
	{
		public int X;
		public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV3)) return false;
            PointV3 other = (PointV3)obj;
            return X == other.X && Y == other.Y;
        }

        public bool Equals(PointV3 other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
