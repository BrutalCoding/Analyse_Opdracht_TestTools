using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Interfaces
{
    public interface IHelloWorld
    {
        /// <summary>
        /// Returns the text "Hello World"
        /// </summary>
        /// <returns>string</returns>
        string ShowHelloWorld();
        /// <summary>
        /// Counts the amount of characters that "HelloWorld" contains
        /// </summary>
        /// <returns>int</returns>
        int CountHelloWorld();
    }
}
