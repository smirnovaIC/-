using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Критерии_оценивания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            string res = a >= 90 && a <= 100 ? "Отлично" : a >= 70 ? "Хорошо" :
                a >= 50 ? "Удовлетворительно" : "Неудовлетворительно";
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
