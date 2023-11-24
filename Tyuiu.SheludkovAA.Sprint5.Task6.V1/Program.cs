using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint5.Task6.V1.Lib;

namespace Tyuiu.SheludkovAA.Sprint5.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V1.txt";

            Console.Title = "Спринт #5 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные взяты из файла : " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество цифр в файле :" + res);
            Console.ReadKey();
        }
    }
}
