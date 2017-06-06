using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    class ColoredLine : Line
    {
        string clr;

        public ColoredLine(int x, int y, int a, int u, string color)
            : base(x, y, a, u)
        {
            Xo = a;
            Yo = u;
            clr = color;

        }
        public override void ToString()
        {
            Console.WriteLine("Line in: Начальная точка ({0},{1}) конечная точка ({2},{3}) color: {4} ", Xpos, Ypos, Xo, Yo, clr);
        }

        private bool Equals(ColoredLine obj)
        {
            if (this == obj) return true;
            if (this.Xo != obj.Xo) return false;
            if (this.Yo != obj.Yo) return false;
            if (this.Xpos != obj.Xpos) return false;
            if (this.Ypos != obj.Ypos) return false;
            if (this.clr != obj.clr) return false;
            return true;
        }
    }
}
