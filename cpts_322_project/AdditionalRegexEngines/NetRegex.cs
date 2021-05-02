using System.Text.RegularExpressions;

namespace cpts_322_project {
    // regex implementation using the builtin .NET regex
    public class NetRegex : GeneralRegex {
        private Regex _regex;

        public NetRegex(string regex) {
            _regex = new Regex(regex);
        }

        public override bool MatchesString(string input) {
            return _regex.IsMatch(input);
        }
    }
}