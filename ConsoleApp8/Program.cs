using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//Задание 10

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите число",
                "Ввод первого числа");
            int name10 = 1;

            int name2 = Int32.Parse(name1);
            int name3 = name2 - name10;
            int name4 = name2 + name10;

            string txt = "Результат: " + name3 + " " + name2 + " " + name4;
            MessageBox.Show(txt, "Итог.");
        }
    }
}
