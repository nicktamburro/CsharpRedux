//the "using" keyword imports a namespace
//a namespace is a collection of classes
//
//these usings are just boilerplate / commonly used ones
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //we use the Console class, which is part of System
            //first line, "using System" makes this available
            Console.WriteLine("Hello, my dudes.");
            Console.ReadLine();
        }
    }
}