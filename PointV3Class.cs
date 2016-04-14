using System;

namespace ValueTypes
{
	class PointV3Class
	{
		public int X;
		public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV3Class)) return false;
            PointV3Class other = (PointV3Class)obj;
            return X == other.X && Y == other.Y;
        }

        public bool Equals(PointV3Class other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
