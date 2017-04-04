using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Interfaces;

namespace TestDemo
{
    public class HelloWorld : IHelloWorld
    {
        public int CountHelloWorld()
        {
            string Text = "Hello World";
            return Text.Length;
        }

        public string ShowHelloWorld()
        {
            return "Hello World";
        }

        public Boolean LeapCalculator(int Year)
        {
            if((Year % 4 == 0 & Year % 100 == 0 & Year % 400 == 0) || (Year % 4 == 0 & Year % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
