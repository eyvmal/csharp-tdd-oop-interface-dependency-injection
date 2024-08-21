namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<char, int> _letterScores;

        public Scrabble(IAlphabet alphabet) {
            _letterScores = alphabet.GetLetterScores();
        }

        public int Score(String word) {
            var total = 0;

            foreach (var ch in word.ToCharArray())
            {
                if (!_letterScores.ContainsKey(ch)) continue;
                var score = _letterScores[ch];
                total += score;
            }
            return total;
        }
    }
}
