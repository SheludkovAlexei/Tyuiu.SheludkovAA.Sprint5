using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint5.Task4.V2.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint5.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V2.txt";
            double wait = 9.982;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
