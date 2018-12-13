using System;
using System.Linq; //used for Contains() method

namespace CS_Practice
{
    /*
     * MISSING N   
     * Given an array and a number as parameters. 
     * The array contains the range of positive integer number 
     * from 1 to N - except one - without duplication in random order. 
     * Write a method which returns the missing number after checking
     * if the collection is valid for the requirements (returns 0 in invalid cases).   
     * Examples:
     * list:    1,2,3,4,6,7,8,9 n:9 
     * result:  5
     * list:    2,6,7,3,5,8,9,1 n:9 
     * result:  4
     * list:    null n:0 
     * result:  0
     * list:    1,2,3,4,5,6,7,8 n:8 
     * result:  0 
     * list:    1,2,3,4,5,6,7,10 n:9 
     * result:  0
     */
    public class MissingN
    {
        static public int missingN(int[] arr, int n)
        {
            if (arr == null || arr.Length != n - 1 || maxValue(arr) > n)
                return 0;
                
            int[] missingNumber = createPool(n);

            for (int i=0; i<arr.Length; i++)
            {
                missingNumber = missingNumber.Where(num => num != arr[i]).ToArray();
            }

            return missingNumber[0];
        }

            static private int maxValue(int[] arr)
            {
                int maxVal = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > maxVal)
                        maxVal = arr[i];
                }

                return maxVal;
            }

            static private int[] createPool(int n)
            {
                int[] pool = new int[n];
                for (int i = 0; i < pool.Length; i++)
                    pool[i] = i + 1;
                return pool;
            }
    }
}
