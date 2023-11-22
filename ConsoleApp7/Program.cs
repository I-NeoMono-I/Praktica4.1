using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


//Задание 9
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите первое число",
                "Ввод первого числа");
            string name2;
            name2 = Interaction.InputBox("Введите второе число",
                "Ввод второго числа");

            int name3 = Int32.Parse(name1);
            int name4 = Int32.Parse(name2);
            int name5 = name3 + name4;

            string txt = "Результат: " + name5;
            MessageBox.Show(txt, "Итог.");
        }
    }
}
