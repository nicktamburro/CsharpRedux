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
    //this is our class, called Program
    class Program
    {
        static void Main(string[] args)
        //like Java:
        //static means this method should be available without instantiating
        //the class... like a JS constructor, etc
        //
        //void... this method returns NOTHING lebowski
        //
        //Main ... this is the entry point
        //
        //our Main only takes one argument, "args" of type string
        //
        //
        {
            //we use the Console class, which is part of System
            //first line, "using System" makes this available
            Console.WriteLine("Hello, my dudes.");
            Console.ReadLine();
        }
    }
}