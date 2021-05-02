using System.Text.RegularExpressions;
using System;


namespace cpts_322_project
{
    public class ConvertToRegex
    {
        // .NET regex flavor
        public const string NetRegex = ".NET Regex";

        // PCRE flavor
        public const string PcreRegex = "PCRE";

        GeneralRegex regexString;

        // ctor: input is the regex text itself, kind should be selected from one of the constants of this class (NetRegex or PcreRegex)
        public ConvertToRegex(string stringInput, string kind)
        {
            switch (kind)
            {
                case ConvertToRegex.NetRegex:
                    regexString = new NetRegex(stringInput);
                    break;
                case ConvertToRegex.PcreRegex:
                    regexString = new PcreRegex(stringInput);
                    break;
                default:
                    throw null;
            }
        }

        // get the created GeneralRegex
        public GeneralRegex getRegex()
        {
            return regexString;
        }

    }
}