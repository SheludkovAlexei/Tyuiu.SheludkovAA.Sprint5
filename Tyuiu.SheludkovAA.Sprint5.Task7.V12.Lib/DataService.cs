using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SheludkovAA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string str = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V12.txt";
            FileInfo fi = new FileInfo(str);
            bool fe = fi.Exists;
            if (fe)
            {
                File.Delete(str);
            }
            string strl="";
            using (StreamReader rdr = new StreamReader(path))
            {
                string line;
                while ((line = rdr.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    strl = line;
                }
                File.AppendAllText(str, strl + Environment.NewLine);
                strl = "";
                
            }
            return str;
        }
    }
}
