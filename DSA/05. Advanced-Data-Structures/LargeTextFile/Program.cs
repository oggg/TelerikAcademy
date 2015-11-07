namespace LargeTextFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        private const string FilePath = @"../../../rfc3261.txt";
        private const int WordsToCount = 1000;

        static void Main()
        {
            var wordsDict = new Dictionary<string, int>();
            char[] splitSymbols = { '.', ',', '!', '?', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', ':', ' ', '<', '>', '=', '"' };

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);

                    if (wordsDict.Count <= WordsToCount)
                    {
                        GetWordsToMatch(wordsDict, words);
                    }
                    else
                    {
                        CountWords(wordsDict, words);
                    }
                }
            }

            var dictKeys = wordsDict.Keys;
            foreach (var w in dictKeys)
            {
                Console.WriteLine("Word {0, -15} occures {1, -5} times.", w, wordsDict[w]);
            }
        }

        private static void GetWordsToMatch(Dictionary<string, int> wordsDict, string[] words)
        {
            foreach (var w in words)
            {
                if (!wordsDict.ContainsKey(w))
                {
                    wordsDict.Add(w, 0);
                    if (wordsDict.Count == WordsToCount)
                    {
                        break;
                    }
                }
            }
        }

        private static void CountWords(Dictionary<string, int> wordsDict, string[] words)
        {
            foreach (var w in words)
            {
                if (wordsDict.ContainsKey(w))
                {
                    wordsDict[w] += 1;
                }
            }
        }
    }
}
