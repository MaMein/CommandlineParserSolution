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


        public int ArgumentsCount { get { return this._Arguments.Count; } }

        public CLParser()
        {
        }


        public void AddArgument(CLArgument theArg)
        {
            this._Arguments.Add(theArg);
        }
    }
}
