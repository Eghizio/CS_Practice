using System;
using System.Collections.Generic; //used List so I can easily push new elements

namespace CS_Practice
{
    /*
     * Longest Row 
     * Write a Solution which find the line with the maximum 
     * number of word count. In case if it has multiple lines
     * with the actual maximum number of words, 
     * then return all those lines.    
     * Input:   a, b, c;
     * Result:  a, b, c;
     * Input:   a, ab, abc;
     * Result:  abc;
     */
    public class LongestRow
    {
        static public string[] longestRow(string[] input)
        {
            List<string> maxRows = new List<string>();
            int maxLen = 0;

            for (int i = 0; i < input.Length; i++)
            {                if(input[i].Length == maxLen)
                {
                    maxRows.Add(input[i]);
                }
                else if(input[i].Length > maxLen)
                {
                    maxRows.Clear();
                    maxLen = input[i].Length;
                    maxRows.Add(input[i]);
                }
            }

            string[] output = maxRows.ToArray();

            return output;
        }
    }
}
