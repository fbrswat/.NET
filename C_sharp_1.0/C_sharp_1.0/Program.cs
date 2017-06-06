using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зауваження: нумерація графів починається з 0, звязок повинен бути між усіма вершинами (принаймі 1)
            try
            {
                List<Edge> start;
                Console.WriteLine("Кiлькiсть вершин: ");
                int v = int.Parse(Console.ReadLine());
                Console.WriteLine("1 - ввести вручну\n2 - завантажити програмою\nIнше - вихiд");
                int x = int.Parse(Console.ReadLine());
                if (x == 1) start = handl(v);
                else if (x == 2) start = auto(v);
                else throw new Exception();
                Console.WriteLine("a:b:price (Вхiдний граф)");
                for (int i = 0; i < start.Count; i++)
                {
                    Console.WriteLine(start[i].v1 + ":" + start[i].v2 + ":" + start[i].weight);
                }
                List<Edge> end = new List<Edge>();
                algorithmByPrim((int)start.Count, start, end);
                Console.WriteLine("a:b:price (Вихiдний граф)");
                for (int i = 0; i < end.Count; i++)
                {
                    Console.WriteLine(end[i].v1 + ":" + end[i].v2 + ":" + end[i].weight);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
                Console.WriteLine("Вихiд");
                return;
                //Console.WriteLine(e);
            }
        }

        public static List<Edge> handl(int x)
        {
            List<Edge> res = new List<Edge>();
            for (int i = 0; i < x; i++)
            {
                System.Console.WriteLine("Введiть початок:");
                int a = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Введiть кiнець:");
                int b = int.Parse(Console.ReadLine());
                while (a == b)
                {
                    System.Console.WriteLine("Початок сходиться з кiнцем, потор:");
                    b = int.Parse(Console.ReadLine());
                }
                System.Console.WriteLine("Введiть цiну:");
                res.Add(new Edge(a, b, int.Parse(Console.ReadLine())));
            }
                return res;
        }

        public static List<Edge> auto(int x)
        {
            List<Edge> res = new List<Edge>();
            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                int a = i;
                int b = a;
                while (a == b)
                {
                    b = random.Next(x);
                }
                res.Add(new Edge(a, b,
                    random.Next(20)));
            }
            return res;
        }

        public static void algorithmByPrim(int numberV, List<Edge> E, List<Edge> MST)
        {
            //неиспользованные ребра
            List<Edge> notUsedE = new List<Edge>(E);
            //использованные вершины
            List<int> usedV = new List<int>();
            //неиспользованные вершины
            List<int> notUsedV = new List<int>();
            for (int i = 0; i < numberV; i++)
                notUsedV.Add(i);
            //выбираем случайную начальную вершину
            Random rand = new Random();
            usedV.Add(rand.Next(0, numberV));
            notUsedV.RemoveAt(usedV[0]);
            while (notUsedV.Count > 0)
            {
                int minE = -1; //номер наименьшего ребра
                //поиск наименьшего ребра
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    if ((usedV.IndexOf(notUsedE[i].v1) != -1) && (notUsedV.IndexOf(notUsedE[i].v2) != -1) ||
                        (usedV.IndexOf(notUsedE[i].v2) != -1) && (notUsedV.IndexOf(notUsedE[i].v1) != -1))
                    {
                        if (minE != -1)
                        {
                            if (notUsedE[i].weight < notUsedE[minE].weight)
                                minE = i;
                        }
                        else
                            minE = i;
                    }
                }
                //заносим новую вершину в список использованных и удал¤ем ее из списка неиспользованных
                //Console.WriteLine(minE);
                if (usedV.IndexOf(notUsedE[minE].v1) != -1)
                {
                    usedV.Add(notUsedE[minE].v2);
                    notUsedV.Remove(notUsedE[minE].v2);
                }
                else
                {
                    usedV.Add(notUsedE[minE].v1);
                    notUsedV.Remove(notUsedE[minE].v1);
                }
                //заносим новое ребро в дерево и удал¤ем его из списка неиспользованных
                MST.Add(notUsedE[minE]);
                notUsedE.RemoveAt(minE);
            }
        }
    }
}
