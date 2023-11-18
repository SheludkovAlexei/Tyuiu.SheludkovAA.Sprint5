using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint5.Task3.V10.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\alex3\source\repos\Tyuiu.SheludkovAA.Sprint5\Tyuiu.SheludkovAA.Sprint5.Task3.V10\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
