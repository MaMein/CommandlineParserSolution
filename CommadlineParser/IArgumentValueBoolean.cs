using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandlineParser.Arguments
{
    interface IArgumentValueBoolean : IArgument
    {
        bool Value { get; set; }
    }



}
