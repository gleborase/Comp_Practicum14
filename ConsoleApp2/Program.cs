using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
        static void Func() 
        {
            for (int i = 0; i <= 4; i++) 
            {
                Console.WriteLine("Привет!");
            }
        }
    }
}
