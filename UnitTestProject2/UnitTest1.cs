using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.btn3_Click(null, EventArgs.Empty);
            mainWindow.btn6_Click(null, (System.Windows.RoutedEventArgs)EventArgs.Empty);
            mainWindow.btnDivide_Click(null, (System.Windows.RoutedEventArgs)EventArgs.Empty);
            mainWindow.btn6_Click(null, EventArgs.Empty);
            mainWindow.btnEqually_Click(null, (System.Windows.RoutedEventArgs)EventArgs.Empty);
            mainWindow.btn1_Click(null, EventArgs.Empty);
            mainWindow.btn1_Click(null, EventArgs.Empty);
            Assert.AreEqual(6, mainWindow.tbZnach);
        }
    }
}
