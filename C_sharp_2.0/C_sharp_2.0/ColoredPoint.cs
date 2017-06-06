using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    class ColoredPoint : Point
    {
        string clr;
        public ColoredPoint(int x, int y, string color)
            : base(x, y)
        {
            clr = color;
        }
        public override void ToString()
        {
            Console.WriteLine("Point in: ({0},{1}) color: {2}", Xpos, Ypos, clr);
        }
        private bool Equals(ColoredPoint obj)
        {
            if (this == obj) return true;
            if (this.Xpos != obj.Xpos) return false;
            if (this.Ypos != obj.Ypos) return false;
            if (this.clr != obj.clr) return false;
            return true;
        }
    }
}
