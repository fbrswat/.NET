using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    abstract class Point
    {
        protected int Xpos;
        protected int Ypos;
        public Point(int x, int y)
        {
            Xpos = x;
            Ypos = y;
        }
        public virtual void ToString()
        {
            Console.WriteLine("Point in: ({0},{1})", Xpos, Ypos);
        }

        private bool Equals(Point obj)
        {
            if (this == obj) return true;
            if (this.Xpos != obj.Xpos) return false;
            if (this.Ypos != obj.Ypos) return false;
            return true;
        }
    }
}
