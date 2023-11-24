using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SheludkovAA.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            double min = -100;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 3 == 0)
                    {
                        if (Convert.ToDouble(line) > min)
                        {
                            min = Convert.ToDouble(line);
                        }
                    }
                }
            }
            for (int i = 1; i < min + 1; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
