using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandlineParser.Arguments;

namespace CommandlineParser
{
    public class CLParser
    {

        List<CLArgument> _Arguments = new List<CLArgument>();
        private readonly string _Commandline;

        public int ArgumentsCount { get { return this._Arguments.Count; } }
        public string Commandline{ get { return _Commandline; } }

        public CLParser()
        {
            _Commandline = Environment.CommandLine;
        }
        

        public void AddArgument(CLArgument theArg)
        {
            this._Arguments.Add(theArg);
        }

        public string[] GetCommandlineArgs()
        {
            return Environment.GetCommandLineArgs();
        }
    }
}
