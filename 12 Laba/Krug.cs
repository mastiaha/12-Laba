using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Laba
{
    static class Krug
    {
        static public double GetPerimetr(int r)
        {
            return 2 * r * Math.PI;
        }
        static public double GetPloshad(int r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        static public double GetGipotenuza(int a, int b, int r)
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if (r >= c)
            {
                Console.WriteLine("Точка принадлежит кругу с радиусом {0}", r);
                return c;
                
            }
            else
            {
                Console.WriteLine("Точка не принадлежит кругу с радиусом {0}", r);
                return c;
            }
            
        }
    }
}
