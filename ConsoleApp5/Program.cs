using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


//Задание 7

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите ваше имя",
                "Ввод имени");
            string name2;
            name2 = Interaction.InputBox("Введите год вашено рождения",
                "Ввод года рождения");
            int name3 = Int32.Parse(name2);
            int name4 = 2023 - name3;

            string txt = "Ваше имя: " + name1 + ", Ваш возраст: " + name4;
            MessageBox.Show(txt, "Итог.");
        }
    }
}
