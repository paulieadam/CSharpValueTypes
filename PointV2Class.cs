using System;

namespace ValueTypes
{
	class PointV2Class
	{
		public int X;
		public int Y;

        public override bool Equals(object obj)
        {
            if (!(obj is PointV2Class)) return false;
            PointV2Class other = (PointV2Class)obj;
            return X == other.X && Y == other.Y;
        }
    }
}
