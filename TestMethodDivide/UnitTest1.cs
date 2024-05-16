using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMethodDivide
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.btn3_Click(null, EventArgs.Empty);
        }
    }
}
