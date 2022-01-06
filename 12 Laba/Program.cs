using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            int r = Convert.ToInt32(Console.ReadLine());
            double perimetr = Krug.GetPerimetr(r);
            double ploshad = Krug.GetPloshad(r);
            Console.WriteLine("Введите координаты точки");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            double c = Krug.GetGipotenuza(a, b, r);
            
            Console.WriteLine($"{perimetr} \n{ploshad}");
            Console.ReadKey();
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
        }
    }
}
