using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Родительский класс Point");
            Console.WriteLine("Point введите координату X ");
            int k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Point введите координату Y ");
            int l = Convert.ToInt16(Console.ReadLine());
            //Point onePointt = new Point(k, l);
            //onePointt.ToString();
            //Console.WriteLine();
            //Console.WriteLine();
            Console.WriteLine("Дочерний класс ColorPoint");
            Console.WriteLine("ColorPointt введите координату X ");
            k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ColorPointt введите координату Y ");
            l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ColorPointt введите цвет");
            string s = Console.ReadLine();
            ColoredPoint pt = new ColoredPoint(k, l, s);
            pt.ToString();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Класс Line, образован от класса Point   ");
            Console.WriteLine("Line введите координату X  ");
            k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Line введите координату Y ");
            l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Координаты конца линии   ");
            Console.WriteLine("Line введите координату X  ");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Line введите координату Y ");
            int z = Convert.ToInt16(Console.ReadLine());
            Line lin = new Line(k, l, m, z);
            lin.ToString();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Класс ColoredLine, образован от класса Line   ");
            Console.WriteLine("ColoredLine введите координату X  ");
            k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ColoredLine введите координату Y ");
            l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Координаты конца линии   ");
            Console.WriteLine("ColoredLine введите координату X  ");
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ColoredLine введите координату Y ");
            z = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ColorLine введите цвет");
            s = Console.ReadLine();
            ColoredLine cln = new ColoredLine(k, l, m, z, s);
            cln.ToString();
            Console.WriteLine();
            Console.WriteLine("Polyline фигура (выведет загруженый с программы):");
            Console.ReadLine();
            Polyline Triangle2 = new Polyline(new List<Line>() { new Line(0, 0, 0, 1),
                                                                   new Line(1, 0, 1, 1),
                                                                   new Line(0, 0, 1, 1) });
            Triangle2.ToString();
        }
    }
}
