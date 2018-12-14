using System;
using System.Collections.Generic; //used for Dictionary/List
using System.Linq; //used for Where()

namespace CS_Practice
{
    /*
     * Duplicate String    
     * Write a Solution which find and count the duplicate values of an array of string values.    
     * INPUT:   "Ala" 
     * RESULT:  ""
     * INPUT:   "Ala ma kota" 
     * RESULT:  "a-3"
     * INPUT:   "International Business Machines" 
     * RESULT:  "n-5, t-2, e-3, a-3, i-3, s-4"
     */
    public class DuplicateString
    {
        static public string duplicateValues(string input)
        {
            char[] arr = input.ToCharArray();
            Dictionary<char, int> duplicates = new Dictionary<char, int>();

            for(int i=0; i<arr.Length; i++)
            {
                if (duplicates.ContainsKey(arr[i]))
                    duplicates[arr[i]]++;
                else
                    duplicates.Add(arr[i], 1);
            }


            foreach(KeyValuePair<char, int> d in duplicates.Where(item => item.Value == 1 || item.Key.Equals(' ')).ToList())
                duplicates.Remove(d.Key);

            //formating output
            string output = "";

            foreach(KeyValuePair<char, int> d in duplicates)
                output += "[" + d.Key.ToString() + "-" + d.Value.ToString() + "]";

            return output;
        }
    }
}
