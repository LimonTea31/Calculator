using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mw = new MainWindow();
            mw.btn1_Click(null, (System.Windows.RoutedEventArgs)EventArgs.Empty);
            mw.btn6_Click(null, (System.Windows.RoutedEventArgs)EventArgs.Empty);
            Assert.AreEqual("16", mw.tbZnach);
        }
    }
}
