using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_2_к
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.Write("Введите порядковый номер месяца: ");
                int.TryParse(Console.ReadLine(), out num);
                if(num <= 0 || num > 12)
                    Console.WriteLine("Некорректный ввод");
            } while (num <= 0 || num > 12);
            Console.WriteLine("До конца года осталось месяцев: " + (12 - num));
            Console.ReadLine();
        }
    }
}
