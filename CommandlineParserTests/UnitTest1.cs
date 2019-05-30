using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandlineParserTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CommadlineParser.Class1 TheObj = new CommadlineParser.Class1();
            TheObj.FirstMethod();
            Assert.Fail(); 
        }
    }
}
