using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    class Polyline
    {
        public Polyline()
        { }

        public Polyline(List<Line> frieng)
        {
            this.Frieng = frieng;
        }

        private List<Line> _Frieng;
        public List<Line> Frieng
        {
            get { return _Frieng; }
            set { _Frieng = value; }
        }

        private bool Equals(Polyline obj)
        {
            if (this == obj) return true;
            if (!_Frieng.SequenceEqual(_Frieng)) return false;
            return true;
        }

        public virtual void ToString()
        {
                Console.WriteLine("Фигура: ");
                for (int i = 0; i < _Frieng.Count; i++)
                    _Frieng[i].ToString();
        }
    }
}
