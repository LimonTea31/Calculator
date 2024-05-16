using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DivideTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ForTestDivide();
            Assert.AreEqual("6", mainWindow.tbZnach);
            //Assert.AreEqual(6, mainWindow.tbZnach);
        }
    }
}
