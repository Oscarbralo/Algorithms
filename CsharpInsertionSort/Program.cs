using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class InsertionSort
    {
        public int[] iSort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int key = input[i];
                int j = i - 1;
                while (j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = key;
            }
            return input;
        }
    }

    public class InsertionSortNonIncreasing
    {
        public int[] iSortNonIncreasing(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int key = input[i];
                int j = i - 1;
                while (j >= 0 && input[j] < key)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = key;
            }
            return input;
        }
    }
}
