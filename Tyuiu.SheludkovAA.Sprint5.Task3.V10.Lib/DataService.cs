using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SheludkovAA.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            FileInfo fi = new FileInfo(path);
            bool fe = fi.Exists;
            if (fe)
            {
                File.Delete(path);
            }
            double y = -1 * Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
        
    }
}
