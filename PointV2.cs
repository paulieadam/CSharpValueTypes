using System;

namespace ValueTypes
{
	struct PointV2
	{
		public int X;
		public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV2)) return false;
            PointV2 other = (PointV2)obj;
            return X == other.X && Y == other.Y;
        }
    }
}
