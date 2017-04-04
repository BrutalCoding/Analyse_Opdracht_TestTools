using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Text: {new HelloWorld().ShowHelloWorld()}");
            Console.WriteLine($"Amount of characters: {new HelloWorld().CountHelloWorld()}");
            Console.ReadLine();
        }
    }
}
