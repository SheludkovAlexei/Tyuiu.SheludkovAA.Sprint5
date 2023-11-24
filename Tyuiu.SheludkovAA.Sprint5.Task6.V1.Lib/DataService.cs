using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SheludkovAA.Sprint5.Task6.V1.Lib
{
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            int cnt = 0;
            using (StreamReader rd = new StreamReader(path))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }
    }
}
