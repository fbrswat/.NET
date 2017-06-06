using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    class Picture
    {
        public List<Point> Point { get; set; }
        public List<ColoredPoint> ColPoint { get; set; }
        public List<Line> Line { get; set; }
        public List<ColoredLine> ColLine { get; set; }
        public List<Polyline> PolyLine { get; set; }

        private bool Equals(Picture obj)
        {
            if (this == obj) return true;
            if (!Point.SequenceEqual(Point)) return false;
            if (!ColPoint.SequenceEqual(ColPoint)) return false;
            if (!Line.SequenceEqual(Line)) return false;
            if (!ColLine.SequenceEqual(ColLine)) return false;
            if (!PolyLine.SequenceEqual(PolyLine)) return false;
            return true;
        }

    }
}
