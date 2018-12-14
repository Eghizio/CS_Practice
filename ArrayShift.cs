using System;
namespace CS_Practice
{
    /*
     * Array Shift 
     * Write a Solution which rotate an array element (shift it) right by one index,
     * and the last element of the array will be moved to the first place.
     * INPUT:   A= [3, 8, 9, 7, 6] and K = 3, 
     * RESULT:  [9, 7, 6, 3, 8]
     * INPUT:   A= [1, 2, 3, 4] and K = 1, 
     * RESULT:  [4, 1, 2, 3]
     */
    public class ArrayShift
    {
        static public int[] arrayShift(int[] arr, int k)
        {
            int[] shifted = new int[arr.Length];


            for(int i=0; i<arr.Length; i++)
                shifted[(i+k)%shifted.Length] = arr[i];

            return shifted;
        }
    }
}
