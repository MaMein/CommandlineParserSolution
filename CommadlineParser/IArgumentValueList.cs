using System.Collections.Generic;

namespace CommandlineParser.Arguments
{
    interface IArgumentValueList : IArgument
    {
        List<string> Value { get; set; }
    }



}
