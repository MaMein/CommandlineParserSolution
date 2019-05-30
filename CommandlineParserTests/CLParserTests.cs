using System;
using CommandlineParser;
using CommandlineParser.Arguments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandlineParserTests
{
    [TestClass]
    public class CLParserTests
    {
        [TestMethod]
        public void Create_CLParser_Without_constructorArguments_Uses_EnvironmentCommandLineArgs()
        {
            CLParser TheParser = new CLParser();
            Assert.AreEqual(Environment.CommandLine, TheParser.Commandline);
        }
       
   
        [TestMethod]
        public void AddArgument_To_CLParser_Is_One_In_its_ArgumentsList()
        {
            CLParser TheParser = new CLParser();
            CLArgumentBoolean TheboolArg = new CLArgumentBoolean("AutorunSwitch", "Autorun", "If True, the Programm starts automatic", true);

            TheParser.AddArgument(TheboolArg);
            Assert.AreEqual(1, TheParser.ArgumentsCount);
        }

        /// <summary>
        /// PreRequesits : CommandlineArguments needs to be : 
        /// -Autorun -Filterfiles "C:\Spiele\*.cfg" -Arg3 -Arg4 "Sentence with Blanks"
        /// </summary>
        [TestMethod]
        public void getCommandlineArgs_From_Application_issame()
        {
            CLParser TheParser = new CLParser();

            string[] CommandLineArgs = TheParser.GetCommandlineArgs();
            string[] ExpectedArgs = new string[]{"-Autorun",
                                    "-Filterfiles",
                                    "C:\\Spiele\\*.cfg\\",
                                    "-Arg3",
                                    "-Arg4",
                                    "Sentence with Blanks" };


            Assert.AreEqual(ExpectedArgs[1], CommandLineArgs[1]);
            Assert.AreEqual(ExpectedArgs[2], CommandLineArgs[2]);
            Assert.AreEqual(ExpectedArgs[3], CommandLineArgs[3]);
            Assert.AreEqual(ExpectedArgs[4], CommandLineArgs[4]);
            Assert.AreEqual(ExpectedArgs[5], CommandLineArgs[5]);
            Assert.AreEqual(ExpectedArgs[6], CommandLineArgs[6]);


        }




    }
}
