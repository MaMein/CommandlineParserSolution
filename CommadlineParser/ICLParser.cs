using CommandlineParser.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandlineParser.Parser
{
    interface ICLParser
    {
        int ArgumentsCount { get; }
        string Commandline { get; }
        string[] CommandlineArgs { get; }

        void AddArgument(IArgument CLArg);

    }
}
