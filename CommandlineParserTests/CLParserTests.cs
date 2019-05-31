using System;
using System.Diagnostics;
using CommandlineParser.Parser;
using CommandlineParser.Arguments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandlineParserTests
{
    [TestClass]
    public class CLParserTests
    {
       
        [TestMethod]
        public void Create_CLParser_with_Custom_Commandline()
        {
            String[] InitArgs = new string[] { "-Autorun", "-Folder", "C:\\Files\\Custom with Blank\\", "-Arg4" };
            String[] ExpectedArgs = new string[] { "-Autorun", "-Folder", "C:\\Files\\Custom with Blank\\", "-Arg4" };

            CLParser TheParser = new CLParser(InitArgs);
            CollectionAssert.AreEqual(ExpectedArgs, TheParser.CommandlineArgs);
        }
        [TestMethod]
        public void AddArgument_To_CLParser_Is_One_In_its_ArgumentsList()
        {
            CLParser TheParser = new CLParser(Environment.GetCommandLineArgs());
            ArgumentValueBoolean TheboolArg = new ArgumentValueBoolean("AutorunSwitch", "Autorun", true,"If True, the Programm starts automatic");

            TheParser.AddArgument(TheboolArg);
            Assert.AreEqual(1, TheParser.ArgumentsCount);
        }
        [TestMethod]
        public void AddBoolArgumentToParser_And_AccessValue()
        {
            CLParser TheParser = new CLParser(Environment.GetCommandLineArgs());

            string ArgumentName = "TestSwitch";
            ArgumentValueBoolean TheboolArg = new ArgumentValueBoolean(ArgumentName, "Autorun",  "If True, the Programm starts automatic");
            TheParser.AddArgument(TheboolArg);

            var theReturnArg = (ArgumentValueBoolean)TheParser.GetArgument(ArgumentName);

            Assert.AreEqual(false, theReturnArg.Value);
        }







    }
}
