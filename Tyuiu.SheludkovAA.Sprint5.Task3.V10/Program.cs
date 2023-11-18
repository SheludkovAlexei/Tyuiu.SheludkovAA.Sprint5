using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint5.Task3.V10.Lib;

namespace Tyuiu.SheludkovAA.Sprint5.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 4;
            
            Console.Title = "Спринт #5 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Переменная равна : "+x);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл :" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
