public class TranslatorSolution
{
    public static void Run()
    {
        var englishToGerman = new TranslatorSolution();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        _words[fromWord] = toWord;
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        string newWord = "???";

        if (_words.ContainsKey(fromWord))
        {
            newWord = _words[fromWord];
        }

        return newWord;
    }
}


// // var letters = new[] {"A", "A", "B", "C", "B", "C"};
//    var summary = new Dictionary<char, int>();
// for (var letter in letters) {
//     if (!summary.ContainsKey(letter))
//     {
//         summary[letter] = 1;
//     }
//     else {
//          summary[letter] += 1;
//     }
    
//     Console.WriteLine(string.Join(", ", summaryTable));
// // [A, 2], [B, 2], [G, 3], [C, 1], [D, 1]
//    }
// // if letter.ContainsKey {
// //    l[letter]=1
// // } 