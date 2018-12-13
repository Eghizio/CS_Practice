using System;

namespace CS_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "a", "ab", "abc"};
            string[] output = LongestRow.longestRow(input);
            foreach(string row in output){
                Console.WriteLine(row);
            }
        }
    }
}