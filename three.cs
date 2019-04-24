//okay so a big thing is there are NO global variable in C#

//instead we do it through a class

using System;

namespace VariableScope
{
    class Program
    {
        private static string helloClass = "Hello, Clash.";

        static void Main(string[] args)
        {
            string helloLocal = "Hello, local band.";
            Console.WriteLine(helloLocal);
            Console.WriteLine(Program.helloClass);
            DoStuff();
        }

        static void DoStuff()
        {
            Console.WriteLine("DoStuff says " + Program.helloClass);
        }
    }
}