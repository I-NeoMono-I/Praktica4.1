using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;


//Задание 3
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name3;
            name3 = Interaction.InputBox("Введите ваше имя",
                "Ввод имени");
            string name4;
            name4 = Interaction.InputBox("Введите ваш возраст",
                "Ввод возраст");
            string txt = "Имя: " + name3 + ", Возраст: " + name4;
            MessageBox.Show(txt, "Итог.");
        }
    }
}
