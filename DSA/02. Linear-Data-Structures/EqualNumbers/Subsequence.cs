namespace EqualNumbers
{
    using System.Collections.Generic;

    public static class Subsequence
    {
        public static List<int> Find(List<int> collection)
        {

            int sameNumbers = 0;
            int longest = 0;
            int index = 0;

            for (int i = 1; i < collection.Count; i++)
            {
                if (collection[i] == collection[i - 1])
                {
                    ++sameNumbers;
                    if (sameNumbers > longest)
                    {
                        longest = sameNumbers;
                        index = i;
                    }
                }
                else
                {
                    sameNumbers = 0;
                }
            }

            var longestSubsequence = new List<int>();

            for (int j = index; j >= index - longest; j--)
            {
                longestSubsequence.Add(collection[j]);
            }

            return longestSubsequence;
        }
    }
}
