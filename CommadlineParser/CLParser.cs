using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandlineParser.Arguments;
using CommandlineParser.Parser;

namespace CommandlineParser.Parser
{
    public class CLParser: ICLParser
    {

        Dictionary<string,IArgument> _Arguments = new Dictionary<string,IArgument>();
        private readonly string _Commandline;
        private readonly string[] _CommandlineArgs;

        #region ICLParser Members

        public int ArgumentsCount { get { return this._Arguments.Count; } }
        public string Commandline { get { return _Commandline; } }
        public string[] CommandlineArgs { get { return _CommandlineArgs; } }

        public void AddArgument(IArgument CLArg)
        {
            this._Arguments.Add(CLArg.Name, CLArg);
        }

        #endregion



        public CLParser(String[] CommandlineArgs)
        {
            _Commandline = String.Join(" ", CommandlineArgs);
            _CommandlineArgs = CommandlineArgs;
        }

        public IArgument GetArgument(string argumentName)
        {
            return _Arguments[argumentName];
        }
    }
}
