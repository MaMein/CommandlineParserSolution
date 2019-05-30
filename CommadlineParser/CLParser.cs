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
        private readonly string _RawCommandline;
        private readonly string[] _RawCommandlineArguments;

        public int ArgumentsCount { get { return this._Arguments.Count; } }
        public string Commandline { get { return _RawCommandline; } }
        public string[] RawCommandlineArguments { get { return _RawCommandlineArguments; } }

        public CLParser()
        {
            _RawCommandline = Environment.CommandLine;
            _RawCommandlineArguments = Environment.GetCommandLineArgs();
        }
        public CLParser(String[] CommandlineArguments)
        {
            _RawCommandline = String.Join(" ", CommandlineArguments);
            _RawCommandlineArguments = CommandlineArguments;
        }
        

        public void AddArgument(CLArgument theArg)
        {
            this._Arguments.Add(theArg);
        }

        public string[] GetEnvironmentCommandlineArgs()
        {
            return Environment.GetCommandLineArgs();
        }
    }
}
