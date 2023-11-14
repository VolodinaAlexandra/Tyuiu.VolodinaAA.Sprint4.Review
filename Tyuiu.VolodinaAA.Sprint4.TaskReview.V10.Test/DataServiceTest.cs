using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint4.TaskReview.V10.Lib;

namespace Tyuiu.VolodinaAA.Sprint4.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string value = "695847142536";
            int res = ds.Calculate(rows, columns, value);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
