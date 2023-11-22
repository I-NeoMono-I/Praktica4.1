using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktica4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            /*
            Console.WriteLine("Введите Имя.");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Фамилию.");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Имя: {name1}, Фамилия: {name2}");
            Console.ReadKey();
            */


            //Задание 3
            /*
            Console.WriteLine("Введите Имя.");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Возраст.");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Имя: {name1}, Возраст: {name2}");
            Console.ReadKey();
            */


            //Задание 4
            /*
            Console.WriteLine("Введите день недели.");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите номер дня недели.");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите дату.");
            string name3 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"День недели: {name1}, Номер дня недели: {name2}, Дата: {name3}");
            Console.ReadKey();
            */


            //Задание 6
            /*
            Console.WriteLine("Введите дату вашего рождения:");
            string name1 = Console.ReadLine();
            int name2 = Int32.Parse(name1);
            Console.Clear();
            int name3 = 2023 - name2;
            
            Console.WriteLine($"Ваш возраст: {name3}" );
            Console.ReadKey();
            */


            //Задание 9

            Console.WriteLine("Введите первое число:");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите первое число:");
            string name2 = Console.ReadLine();
            int name3 = Int32.Parse(name1);
            int name4 = Int32.Parse(name2);
            Console.Clear();
            int name5 = name3 + name4;

            Console.WriteLine($"Результат: {name5}");
            Console.ReadKey();

        }
    }
}
