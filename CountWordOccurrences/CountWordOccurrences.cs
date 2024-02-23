using System;

class Program
{
    static int CountWordOccurrences(string sentence, string word)
    {
        // Разбиваем предложение на слова, игнорируя регистр
        string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string w in words)
        {
            if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase)) // Сравнение без учета регистра
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        string sentence = "Hello world, hello universe, hello everyone!";
        string word = "hello";

        int occurrences = CountWordOccurrences(sentence, word);
        Console.WriteLine($"Слово '{word}' встречается {occurrences} раз.");
    }
}
