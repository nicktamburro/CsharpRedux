//okay so a big thing is there are NO global variable in C#

//instead we do it through a class

using System;

namespace VariableScope
{
    class Program
    {
        //helloClass is declared in the scope of the 
        //Program class, so we can use it in Main AND DoStuff()
        private static string helloClass = "Hello, Clash.";

        static void Main(string[] args)
        {
            //helloLocal can only be used in Main.... scope!
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