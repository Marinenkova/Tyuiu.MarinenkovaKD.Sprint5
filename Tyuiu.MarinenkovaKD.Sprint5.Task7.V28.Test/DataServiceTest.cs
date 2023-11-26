using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MarinenkovaKD.Sprint5.Task7.V28.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint5.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Я твой-ты моя\source\repos\Tyuiu.MarinenkovaKD.Sprint5\Tyuiu.MarinenkovaKD.Sprint5.Task7.V28\bin\Debug\OutPutFileTask7V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
