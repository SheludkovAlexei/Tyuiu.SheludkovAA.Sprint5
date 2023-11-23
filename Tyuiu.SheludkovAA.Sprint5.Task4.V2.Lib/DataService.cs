using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = Convert.ToDouble(strx);
            double res = Math.Round((Math.Cos(x) + 3 * x) / (0.25 * x) + 4 - 2.1 * x, 3);
            return res;
        }
    }
}
