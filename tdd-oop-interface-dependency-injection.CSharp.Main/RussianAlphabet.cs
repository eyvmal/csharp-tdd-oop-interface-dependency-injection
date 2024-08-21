namespace tdd_oop_interface_dependency_injection.CSharp.Main;

public class RussianAlphabet : IAlphabet
{
    public Dictionary<char, int> GetLetterScores()
    {
        var words = new Dictionary<char, int>
        {
            { 'а', 1 },
            { 'б', 1 },
            { 'в', 1 },
            { 'г', 1 },
            { 'д', 1 },
            { 'е', 2 },
            { 'ё', 2 },
            { 'ж', 2 },
            { 'з', 2 },
            { 'и', 2 },
            { 'й', 3 },
            { 'к', 3 },
            { 'л', 3 },
            { 'м', 3 },
            { 'н', 3 },
            { 'о', 4 },
            { 'п', 4 },
            { 'р', 4 },
            { 'с', 4 },
            { 'т', 4 },
            { 'у', 4 },
            { 'ф', 4 },
            { 'х', 5 },
            { 'ц', 5 },
            { 'ч', 5 },
            { 'ш', 5 },
            { 'щ', 8 },
            { 'ъ', 8 },
            { 'ы', 8 },
            { 'ь', 10 },
            { 'э', 10 },
            { 'ю', 10 },
        };
        return words;
    }
}
