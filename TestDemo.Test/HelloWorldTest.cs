using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Interfaces;

namespace TestDemo.Test
{
    [TestFixture]
    public class HelloWorldTest
    {
        [TestCase]
        public void CountHelloWorld()
        {
            HelloWorld HW = new HelloWorld();
            int response = HW.CountHelloWorld();
            Assert.AreEqual(11, response);
        }

        [TestCase]
        public void ShowHelloWorld()
        {
            HelloWorld HW = new HelloWorld();
            string response = HW.ShowHelloWorld();
            Assert.AreEqual("Hello World", response);
        }
    }
}
