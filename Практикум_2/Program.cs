using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            bool prov;
            do
            {
                Console.Write("Введите x = ");
                prov = float.TryParse(Console.ReadLine(), out x);
                if(!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите y = ");
                prov = float.TryParse(Console.ReadLine(), out y);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            if (x * x + y * y < 81 && x > 0)
                Console.WriteLine("Точка внутри области");
            else if (x * x + y * y > 81 || x < 0)
                Console.WriteLine("Точка вне области");
            else Console.WriteLine("Точка на границе");
            Console.ReadLine();
        }
    }
}
