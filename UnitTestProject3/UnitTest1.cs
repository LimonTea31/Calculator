using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using System.Windows.Controls;

namespace UnitTestProject3
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mainWindow = new MainWindow();
            var args = new RoutedEventArgs(Button.ClickEvent);
            mainWindow.EmulateButtonClick();
            Assert.AreEqual("720", mainWindow.tbZnach);
        }
    }
}
