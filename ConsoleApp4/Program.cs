using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


//Задание 5
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите название месяца",
                "Ввод месяца");
            string name2;
            name2 = Interaction.InputBox("Введите количество дней в месяце",
                "Ввод количество дней");
            string name3;
            
            string txt = "Месяц: " + name1 + ", Количество дней: " + name2;
            MessageBox.Show(txt, "Итог.");
        }
    }
}
