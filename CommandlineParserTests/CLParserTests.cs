using System;
using System.Diagnostics;
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
        public void Create_CLParser_with_Custom_Commandline()
        {
            String[] InitArgs = new string[] { "-Autorun", "-Folder", "C:\\Files\\Custom with Blank\\", "-Arg4" };
            String[] ExpectedArgs = new string[] { "-Autorun", "-Folder", "C:\\Files\\Custom with Blank\\", "-Arg4" };

            CLParser TheParser = new CLParser(InitArgs);
            CollectionAssert.AreEqual(ExpectedArgs, TheParser.RawCommandlineArguments);
        }
        [TestMethod]
        public void AddArgument_To_CLParser_Is_One_In_its_ArgumentsList()
        {
            CLParser TheParser = new CLParser();
            CLArgumentBoolean TheboolArg = new CLArgumentBoolean("AutorunSwitch", "Autorun", "If True, the Programm starts automatic", true);

            TheParser.AddArgument(TheboolArg);
            Assert.AreEqual(1, TheParser.ArgumentsCount);
        }

    
        




    }
}
