using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{

    public class Program
    {
        private const int NumberOfPoints = 10000000;
        private const int Repititions = 10;

        static void SearchPointInList<TPoint>(string description, Func<int, TPoint> pointMaker)
            where TPoint : struct
        {
            List<TPoint> points = new List<TPoint>();

            for (int i = 0; i < NumberOfPoints; ++i)
            {
                points.Add(pointMaker(i));
            }

            TPoint toFind = pointMaker(NumberOfPoints + 1);
            int gen0CollectionsAtStart = GC.CollectionCount(0);

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < Repititions; ++i)
            {
                points.Contains(toFind);
            }

            sw.Stop();

            Console.WriteLine($"{description} \n\tAverage time per lookup: {sw.ElapsedMilliseconds / Repititions} ms \n\tGarbage collections: { GC.CollectionCount(0) - gen0CollectionsAtStart } ");
        }


        public void Main()
        {
            SearchPointInList("Naked struct", i => new PointV1 { X = i, Y = i });
            SearchPointInList("With Equals override", i => new PointV2 { X = i, Y = i });
            SearchPointInList("With Equals overload", i => new PointV3 { X = i, Y = i });
            SearchPointInList("With IEquatable", i => new PointV4 { X = i, Y = i });
            SearchPointInList("All", i => new PointV5 { X = i, Y = i });
        }
    }
}
