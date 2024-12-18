using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n=");
            Func(n);
            Console.Read();
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Func(int n)
        {
            for (int i=1; i <= n; i++) 
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
