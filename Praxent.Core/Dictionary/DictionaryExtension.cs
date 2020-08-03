using System.Collections.Generic;

namespace Praxent.Core.Dictionary
{
    public static class DictionaryExtension
    {
        public static void AddItemIfNotNull(this IDictionary<string, string> dictionary, string key, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                dictionary.Add(key, value);
            }
        }
    }
}