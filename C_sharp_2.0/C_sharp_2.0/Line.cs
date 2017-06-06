using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    class Line : Point
    {
        protected int Xo;
        protected int Yo;
        public Line(int x, int y, int a, int u)
            : base(x, y)
        {
            Xo = a;
            Yo = u;
        }


        // Overloading '*' operator:
        public static Line operator *(Line a, Line b)
        {
            return new Line(a.Xpos * b.Xpos, a.Ypos * b.Ypos, a.Xo * b.Xo, a.Yo * b.Yo);
        }

        // Overloading '/' operator:
        public static Line operator /(Line a, Line b)
        {
            return new Line(a.Xpos / b.Xpos, a.Ypos / b.Ypos, a.Xo / b.Xo, a.Yo / b.Yo);
        }

        // Overloading '+' operator:
        public static Line operator +(Line a, Line b)
        {
            return new Line(a.Xpos + b.Xpos, a.Ypos + b.Ypos, a.Xo + b.Xo, a.Yo + b.Yo);
        }

        // Overloading '-' operator:
        public static Line operator -(Line a, Line b)
        {
            return new Line(a.Xpos - b.Xpos, a.Ypos - b.Ypos, a.Xo - b.Xo, a.Yo - b.Yo);
        }

        public override void ToString()
        {
            Console.WriteLine("Line in: Начальная точка ({0},{1}) конечная точка ({2},{3}) ", Xpos, Ypos, Xo, Yo);
        }

        private bool Equals(Line obj)
        {
            if (this == obj) return true;
            if (this.Xo != obj.Xo) return false;
            if (this.Yo != obj.Yo) return false;
            if (this.Xpos != obj.Xpos) return false;
            if (this.Ypos != obj.Ypos) return false;
            return true;
        }
    }
}
