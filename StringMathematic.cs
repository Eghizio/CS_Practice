using System;
namespace CS_Practice
{
    /*
     * String Mathematic   
     * Write a solution to calculate mathematic expression based on string value   
     * Input:   "1 + 2 * 4" 
     * Output:  9
     * Input:   "2 * (2 + 2 * 2)" 
     * Output:  12
     * Input:   "(1 + 3 * 3) / 2" 
     * Output:  5 
     */
    public class StringMathematic
    {
        static public float stringMathematic(string input) //eval(works without order of operations & brackets and numbers 0-9)
        {
            char[] arr = input.Replace(" ", String.Empty).ToCharArray();
            // [1+2*4] = 9
            //returns 12 cause 1+2 = 3, 3*4 = 12

            float num = 0;
            bool prevSign = false;

            for(int i=0; i<arr.Length; i++)
            {
                if (prevSign)
                {
                    prevSign = false;
                    switch(arr[i-1])
                    {
                        case '+':
                            num += float.Parse(arr[i].ToString());
                            break;
                        case '-':
                            num -= float.Parse(arr[i].ToString());
                            break;
                        case '*':
                            num *= float.Parse(arr[i].ToString());
                            break;
                        case '/':
                            num /= float.Parse(arr[i].ToString());
                            break;
                    }
                }
                else if (char.IsDigit(arr[i]))
                    num = float.Parse(arr[i].ToString());
                else if (arr[i].Equals('+') ||
                         arr[i].Equals('-') ||
                         arr[i].Equals('*') ||
                         arr[i].Equals('/'))
                    prevSign = true;
            }
            return num;
        }
    }
}
