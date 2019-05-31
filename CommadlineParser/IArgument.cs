using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandlineParser.Arguments;

namespace CommandlineParser.Arguments
{
    public interface IArgument
    {
        string Description { get; }
        string Commandlinename { get; }
        string Name { get; }
      
    }
}
