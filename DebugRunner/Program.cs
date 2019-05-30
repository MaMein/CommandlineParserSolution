using CommandlineParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugRunner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Appplication Commandline Arguments:");
            Console.WriteLine(String.Join(";",args));
            Console.WriteLine("");

            Console.WriteLine("Parser Commandline Arguments:");
            CLParser TheParser = new CLParser();
            Console.WriteLine(String.Join(";", TheParser.GetEnvironmentCommandlineArgs()));
            Console.WriteLine("");

            Console.WriteLine("[Enter] zum schliessen...");
            Console.ReadLine();
        }
    }
}
