using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_MostUsedWords
{
    public class MostUsedWords
    {
        struct Word
        {
            public string Text { get; set; }
            public int Count { get; set; }
        }

        public static Dictionary<string, int>  GetTopOccurrences(string text, int top)
        {
            return text
                .Split(" ,.;()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLowerInvariant())
                .GroupBy(w => w)
                .Select(g => new Word { Text = g.Key, Count = g.Count() })
                .OrderByDescending(w => w.Count)
                .ThenBy(w => w.Text)
                .Take(top)
                .ToDictionary(w => w.Text, w => w.Count);
        }
    }
}