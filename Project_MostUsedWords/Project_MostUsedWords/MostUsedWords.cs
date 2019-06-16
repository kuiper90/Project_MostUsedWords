using System.Collections.Generic;
using System.Linq;

namespace Project_MostUsedWords
{
    public class MostUsedWords
    {
        public static Dictionary<string, int>  GetTopOccurrences(string text, int top)
        {
            char[] charToTrim = {',', ';', '(', ')', '.'};
            string[] words = text.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerWord = word.ToLowerInvariant().Trim(charToTrim);
                if (!wordCount.ContainsKey(lowerWord))
                    wordCount.Add(lowerWord, 1);
                else
                    wordCount[lowerWord]++;
            }
            Dictionary<string, int> wordsCount = wordCount;
            return wordCount
                .Select(w => w)
                .OrderByDescending(k => k.Value)
                .Take(top)
                .ToDictionary(kw => kw.Key, kw => kw.Value);
        }
    }
}
