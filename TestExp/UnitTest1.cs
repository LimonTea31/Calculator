using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestExp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mw = new MainWindow();
            mw.ForTestExp();
            Assert.AreEqual("Ошибка деления на 0",mw.tbZnach);
        }
    }
}
