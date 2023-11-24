using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint5.Task6.V1.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint5.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V1.txt";
            double wait = 6;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
