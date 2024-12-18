using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Задание 4. С использованием цветового оформления консоли: а) вывести на экран горизонтальную строку из 18 символов; б) вывести на экран вертикальную строку из 25 символов.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // инициализациядля невидимого курсора
            bool saveCursorVisibile = Console.CursorVisible;
            Console.Title = "Работа с консолью";
            Console.BackgroundColor = ConsoleColor.White;//свойство установки белого цвета фона для текста
            Console.ForegroundColor = ConsoleColor.Red;// свойство установки красного цвета шрифта
            Func();
            Func1();
            Console.Read();
        }
        static void Func()
        {
            for (int x = 1; x <= 18; x++)
            { 
                Console.Write("#");
            } 
        }
        static void Func1()
        {
            for (int x = 1; x <= 25; x++)
            {
                Console.WriteLine("#");
            }
        }
    }
}
