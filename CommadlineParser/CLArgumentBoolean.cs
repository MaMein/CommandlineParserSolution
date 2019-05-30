using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandlineParser.Arguments
{
    public class CLArgumentBoolean : CLArgument
    {
        private bool _Value;

        public bool Value { get => _Value; set => _Value = value; }

        public CLArgumentBoolean(String Name,String CommandlineName, String Description,bool Value)
            :base(Name,CommandlineName,Description)
        {
            this._Value = Value;
        }

        
    }
}
