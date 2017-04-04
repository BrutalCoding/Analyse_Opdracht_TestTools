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
        void Setup()
        {
            HW = new HelloWorld();
        }

        [TestCase]
        void CountHelloWorld()
        {
            int response = HW.CountHelloWorld();
            Assert.AreEqual(11, response);
        }

        [TestCase]
        void ShowHelloWorld()
        {
            string response = HW.ShowHelloWorld();
            Assert.AreEqual("Hello World", response);
        }

        [TestCase]
        void LeapCalculator()
        {
            Boolean response = HW.LeapCalculator(1994);
            Assert.AreEqual(false, response);
        }

        [TearDown]
        void Uninitialize()
        {
            HW = null;
        }
    }
}
