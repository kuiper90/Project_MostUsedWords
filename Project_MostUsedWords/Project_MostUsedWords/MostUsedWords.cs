﻿using System.Collections.Generic;
using System.Linq;

namespace Project_MostUsedWords
{
    public class MostUsedWords
    {
        public static Dictionary<string, int>  GetTopOccurrences(string text, int top)
        {
            char[] charToTrim = {',', ';', '(', ')', '.'};

            return text
                .Split(' ')
                .Aggregate(new Dictionary<string, int>(), (wordCount, word) => {
                    string lowerWord = word
                                        .ToLowerInvariant()
                                        .Trim(charToTrim);
                    if (!wordCount.ContainsKey(lowerWord))
                        wordCount.Add(lowerWord, 1);
                    else
                        wordCount[lowerWord]++;
                    return wordCount;
                })
                .Select(w => w)
                .OrderByDescending(k => k.Value)
                .Take(top)
                .ToDictionary(kw => kw.Key, kw => kw.Value);
        }
    }
}
