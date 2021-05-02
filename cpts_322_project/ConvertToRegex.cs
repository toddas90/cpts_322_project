using System.Text.RegularExpressions;
using System;


namespace cpts_322_project
{
    public class ConvertToRegex
    {
        string inputString;
        Regex regexString;
        public ConvertToRegex(string stringInput)
        {
            inputString = stringInput;
            regexString = new Regex(stringInput);
        }

        public bool stringEmpty()
        {
            if (inputString.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Regex getRegex()
        {
            return regexString;
        }

    }
}