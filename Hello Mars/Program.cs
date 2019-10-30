using System;
using System.Threading;
using System.Diagnostics;
using static System.Console;

namespace Hello_Mars
{
    class Program
    {
        static void Main(string[] args)
        {/*
            WARNING MAY CRASH YOUR COMPUTER
            JUST OPENS INFINTE PROCESSES
            */
            while (true)
            {
                Console.WriteLine("Hello Mars!"); // regular
                Console.WriteLine("Hello\nMars!"); // \n new line
                Console.WriteLine("Hello\bMars!"); // \b backspace
                Console.WriteLine("Hello\tMars!"); // \t tab
                Console.WriteLine("Hello\\Mars!"); // \\ backslash '\'
                Console.WriteLine("Hello\'Mars!"); // \' apstrophe '
                Console.WriteLine("Hello\"Mars!"); // quotation mark "
                Console.WriteLine("Hello\u0041 Mars!"); // \u**** unicode
                Console.WriteLine("Hello\u0061 Mars!");
                Console.WriteLine("Hello \u00BC Mars!");
                Console.WriteLine("Hello \u00BD Mars!");
                Console.WriteLine(Environment.CurrentDirectory);

                string fileName = Environment.CurrentDirectory;
                fileName = fileName + "\\Hello Mars.exe";
                Console.WriteLine(fileName);
                Process.Start(fileName);
            }



        }
    }
}
