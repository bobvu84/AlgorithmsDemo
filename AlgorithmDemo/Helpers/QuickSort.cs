using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo.Helpers
{
    public class QuickSort
    {
        private int[] numbers;
        private int count;
        public void sort(int[] values)
        {
            //check for empty or null array
            if (values == null || values.Length == 0)
            {
                return;
            }
            this.numbers = values;
            count = values.Length;
            quickSort(0, count - 1);

        }

        public void quickSort(int low, int high)
        {
            int i = low, j = high;
            //Get Pivot from the middle of the list
            int pivot = numbers[low + (high - low) / 2];
            //Divide into two lists
            while (i <= j)
            {
                //if the current value from the left list is smaller than the pivot
                //element then get the next element from the left list
                while (numbers[i] < pivot)
                {
                    i++;
                }
                while (numbers[j] > pivot)
                {
                    j--;
                }
                //if we find a value in the left list which is larger than the
                //pivot element and if we find a value in the right list which is 
                //smaller than the pivot element then we exchanges the values.
                if (i <= j)
                {
                    exchange(i, j);
                    i++;
                    j--;
                }
                //Recursion
                if (low < j)
                {
                    quickSort(low, j);
                }
                if (i < high)
                {
                    quickSort(i, high);
                }
            }
            
        }

        private void exchange(int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
