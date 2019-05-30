namespace CommandlineParser.Arguments
{
    public class CLArgument
    {
        private readonly string _name;
        private readonly string _commandlinename;
        private readonly string _description;


        public string Description => _description;
        public string Commandlinename => _commandlinename;
        public string Name => _name;


        public CLArgument(string Name,string Commandlinename,string Description)
        {
            this._name = Name;
            this._commandlinename = Commandlinename;
            this._description = Description;
        }

    }
}