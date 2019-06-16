using static Project_MostUsedWords.MostUsedWords;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace UnitTest_MostUsedWords
{
    public class UnitTest_MostUsedWords
    {
        [Fact]
        public void GetTopOccurrences_ShouldReturn_First_KeyValuePair()
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rutrum lobortis porta. Vivamus convallis non augue at feugiat. Fusce ultricies mi vel faucibus blandit. Aliquam ultricies ornare elementum. Duis vel lectus risus. Quisque sed lacinia ligula. Sed eu orci dui. Sed elementum imperdiet auctor. Duis eget quam eleifend, pharetra elit hendrerit, mattis arcu. Nunc dolor metus, viverra vel orci facilisis, cursus accumsan turpis. Vestibulum sit amet mauris dapibus, ullamcorper quam sed, pretium quam. Donec imperdiet lobortis nisi, in rutrum lacus accumsan quis.";
            Dictionary<string, int> dict = GetTopOccurrences(text, 7);
            Assert.True(dict.Keys.ElementAt(0) == "sed");
            Assert.True(dict[dict.Keys.ElementAt(0)] == 4);
        }

        [Fact]
        public void GetTopOccurrences_ShouldReturn_Second_KeyValuePair()
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rutrum lobortis porta. Vivamus convallis non augue at feugiat. Fusce ultricies mi vel faucibus blandit. Aliquam ultricies ornare elementum. Duis vel lectus risus. Quisque sed lacinia ligula. Sed eu orci dui. Sed elementum imperdiet auctor. Duis eget quam eleifend, pharetra elit hendrerit, mattis arcu. Nunc dolor metus, viverra vel orci facilisis, cursus accumsan turpis. Vestibulum sit amet mauris dapibus, ullamcorper quam sed, pretium quam. Donec imperdiet lobortis nisi, in rutrum lacus accumsan quis.";
            Dictionary<string, int> dict = GetTopOccurrences(text, 7);
            var key = dict.FirstOrDefault(d => d.Value == 3).Key;
            Assert.True(key == "vel");
        }

        [Fact]
        public void GetTopOccurrences_ShouldReturn_Last_KeyValuePair()
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rutrum lobortis porta. Vivamus convallis non augue at feugiat. Fusce ultricies mi vel faucibus blandit. Aliquam ultricies ornare elementum. Duis vel lectus risus. Quisque sed lacinia ligula. Sed eu orci dui. Sed elementum imperdiet auctor. Duis eget quam eleifend, pharetra elit hendrerit, mattis arcu. Nunc dolor metus, viverra vel orci facilisis, cursus accumsan turpis. Vestibulum sit amet mauris dapibus, ullamcorper quam sed, pretium quam. Donec imperdiet lobortis nisi, in rutrum lacus accumsan quis.";
            Dictionary<string, int> dict = GetTopOccurrences(text, 7);
            dict.TryGetValue("elit", out int value);
            Assert.True(value == 2);
        }
    }
}
