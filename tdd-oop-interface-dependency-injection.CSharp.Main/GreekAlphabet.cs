namespace tdd_oop_interface_dependency_injection.CSharp.Main;

public class GreekAlphabet : IAlphabet
{
    public Dictionary<char, int> GetLetterScores()
    {
        var words = new Dictionary<char, int>
        {
            { 'α', 1 },
            { 'ε', 1 },
            { 'ι', 1 },
            { 'ο', 1 },
            { 'φ', 1 },
            { 'ξ', 1 },
            { 'β', 2 },
            { 'δ', 2 },
            { 'π', 2 },
            { 'γ', 3 },
            { 'η', 3 },
            { 'ν', 3 },
            { 'τ', 3 },
            { 'ζ', 4 },
            { 'κ', 4 },
            { 'ρ', 4 },
            { 'ψ', 4 },
            { 'λ', 4 },
            { 'θ', 5 },
            { 'χ', 5 },
            { 'μ', 8 },
            { 'σ', 8 },
            { 'υ', 10 },
            { 'ω', 10 },
        };
        return words;
    }
}