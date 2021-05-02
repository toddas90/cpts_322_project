namespace cpts_322_project {
    // regex flavor using the PCRE flavor
    public class PcreRegex : GeneralRegex {
        private PCRE.PcreRegex _regex;

        public PcreRegex(string regex) {
            _regex = new PCRE.PcreRegex(regex);
        }

        public override bool MatchesString(string input) {
            return _regex.IsMatch(input);
        }
    }
}