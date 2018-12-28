using System;
using System.Text; //using for StringBuilder

namespace CS_Practice
{
    /*
     * Revert String expect 'a'    
     * Write a Solution which change order of string 
     * but all 'a' have remain in same position. 
     * Do not use 'Sort' and use only one loop.    
     * INPUT:   Marek;
     * RESULT:  kaerM;
     * INPUT:   Monia;
     * RESULT:  inoMa;
     */
    public class RevertString
    {
        static public string revertString(string input)
        {
            int l = 0;
            int r = input.Length - 1;
            char[] arr = input.ToCharArray();

            while (l < r)
            {
                if (arr[l].Equals('a'))
                    l++;
                else if (arr[r].Equals('a'))
                    r--;           
                else
                {
                    char temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                    r--;
                }
            }
            input = new string(arr);
            return input;
        }
    }
}
