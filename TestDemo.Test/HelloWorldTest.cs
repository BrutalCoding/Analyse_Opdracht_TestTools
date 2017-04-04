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
        HelloWorld HW;
        [SetUp]
        public void Setup()
        {
            HW = new HelloWorld();
        }

        [TestCase]
        public void CountHelloWorld()
        {
            int response = HW.CountHelloWorld();
            Assert.AreEqual(11, response);
        }

        [TestCase]
        public void ShowHelloWorld()
        {
            string response = HW.ShowHelloWorld();
            Assert.AreEqual("Hello World", response);
        }

        [TestCase]
        public void LeapCalculator()
        {
            Boolean response = HW.LeapCalculator(1994);
            Assert.AreEqual(false, response);
        }


    }
}
