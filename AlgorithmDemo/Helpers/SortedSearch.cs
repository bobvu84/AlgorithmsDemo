using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo.Helpers
{
    public class SortedSearch
    {
        /*
         * Implement function CountNumbers that accepts a sorted array of integers and counts the number of array elements that are less than the parameter lessThan.
            For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.
         */
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int count = sortedArray.Length;

            int i = firstIndex(sortedArray, 0, count - 1, lessThan, count);
            int j = lastIndex(sortedArray, 0, count - 1, lessThan, count);

            if (i == -1 || j == -1)
            {
                return 0;
            }

            return j - i + 1;

        }
        public static int firstIndex(int[] partition, int low, int high, int lessThan, int length)
        {
            if (high >= low)
            {
                
                if (partition[low] >= lessThan)
                {
                    return -1;
                }
                else
                {
                    return low;
                }
            } else
            {
                return -1;
            }
            
            
        }
        public static int lastIndex(int[] partition, int low, int high, int lessThan, int length)
        {
            if (high >= low)
            {
                int midPos = (low + high) / 2;
                if (midPos == 0)
                {
                    return midPos;
                } else if (midPos == length - 1 || (partition[midPos] < lessThan && partition[midPos + 1] >= lessThan))
                {
                    return midPos;
                }
                if (partition[midPos] < lessThan)
                {
                    length = midPos;
                    return lastIndex(partition, midPos + 1, high, lessThan, length);
                }
                else
                {
                    return lastIndex(partition, low, midPos - 1, lessThan, length);
                }
            } else
            {
                return -1;
            }            
        }



        /* if x is present in arr[] then returns 
        the count of occurrences of x, 
        otherwise returns -1. */
        public static int CountOccurences(int[] sortedArray, int x, int arrayLength)
        {
            //Index of first occurence of x in sortedArray
            int i;
            //Index of last occurence of x in sortedArray
            int j;
            /* get the index of first occurrence of x */
            i = first(sortedArray, 0, arrayLength - 1, x, arrayLength);

            /* If x doesn't exist in arr[] then return -1 */
            if (i == -1)
                return i;

            /* Else get the index of last occurrence of x. 
               Note that we are only looking in the 
               subarray after first occurrence */
            j = last(sortedArray, i, arrayLength - 1, x, arrayLength);

            /* return count */
            return j - i + 1;

            //return 0;

        }

        /* if x is present in arr[] then returns the 
       index of FIRST occurrence of x in arr[0..n-1], 
       otherwise returns -1 */
        public static int first(int[] arr, int low, int high, int x, int arrayLength)
        {
            if (high >= low)
            {
                /*low + (high - low)/2;*/
                int mid = (low + high) / 2;
                if ((mid == 0 || x > arr[mid - 1]) && arr[mid] == x)
                    return mid;
                else if (x > arr[mid])
                    return first(arr, (mid + 1), high, x, arrayLength);
                else
                    return first(arr, low, (mid - 1), x, arrayLength);
            }
            return -1;
        }

        /* if x is present in arr[] then returns the 
       index of LAST occurrence of x in arr[0..n-1], 
       otherwise returns -1 */
        public static int last(int[] arr, int low, int high, int x, int arrayLength)
        {
            if (high >= low)
            {
                /*low + (high - low)/2;*/
                int mid = (low + high) / 2;
                if ((mid == arrayLength - 1 || x < arr[mid + 1]) && arr[mid] == x)
                    return mid;
                else if (x < arr[mid])
                    return last(arr, low, (mid - 1), x, arrayLength);
                else
                    return last(arr, (mid + 1), high, x, arrayLength);
            }
            return -1;
        }
    }
}




/* COUNT NUMBER - Slow implementation
 
            int total = 0;
            int midPos;
            if (sortedArray[count-1] < lessThan)
            {
                return count;
            }

            midPos = count / 2;

            for (int j = 0; j<count; j++)
            {
                if (sortedArray[j] < lessThan)
                {
                    total = total + 1;
                }
                if (sortedArray[j] >= lessThan)
                {
                    break;
                }
            }
            if (sortedArray[midPos] >= lessThan)
            {
                for (int i = 0; i < midPos ; i++)
                {
                    if (sortedArray[i] < lessThan)
                    {
                        total = total + 1;
                    }
                }
            }
            else
            {
                total = midPos;
                for (int i = midPos; i < count; i++)
                {
                    if (sortedArray[i] < lessThan)
                    {
                        total++;
                    }
                }
            }
            return total;
     */
