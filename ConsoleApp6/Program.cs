using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//Задание 8
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите ваш возраст",
                "Ввод возраста");
            
            int name2 = Int32.Parse(name1);
            int name3 = 2023 - name2;

            string txt = "Год вашего рождения: " + name3;
            MessageBox.Show(txt, "Итог.");
        }
    }
}
