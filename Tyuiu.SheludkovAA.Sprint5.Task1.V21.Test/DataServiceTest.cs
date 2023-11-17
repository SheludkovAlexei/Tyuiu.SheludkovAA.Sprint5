using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint5.Task1.V21.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint5.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\alex3\source\repos\Tyuiu.SheludkovAA.Sprint5\Tyuiu.SheludkovAA.Sprint5.Task1.V21\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
