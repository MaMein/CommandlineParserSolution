using CommandlineParser.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandlineParser.Arguments
{
    public class ArgumentValueBoolean : IArgumentValueBoolean
    {

        bool _Value;
        string _Description;
        string _Commandlinename;
        string _Name;

        #region IArgumentValueBoolean Members
        public bool Value { get => _Value; set => _Value = Value; }
        public string Description { get => _Description; }
        public string Commandlinename { get => _Commandlinename; }
        public string Name { get => _Name; }
        #endregion

        public ArgumentValueBoolean(String Name, string Commandlinename, string Description)
        {
            _Name = Name;
            _Commandlinename = Commandlinename;
            _Value = false;
            _Description = Description;
        }
        public ArgumentValueBoolean(String Name, string Commandlinename, Boolean Value, string Description)
        {
            _Name = Name;
            _Commandlinename = Commandlinename;
            _Value = Value;
            _Description = Description;
        }

    }
}
