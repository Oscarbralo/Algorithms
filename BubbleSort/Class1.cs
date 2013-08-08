using System;

namespace BubbleSortDLL
{
    public class BubbleSort
    {
        public int[] bubbleSort(int[] input)
        {
            int temp = 0;
            int x = 0;
            for (int i = 0; i < input.Length; i++)
            {
                x = 0;
                for (int a = x + 1; a < input.Length - i; a++)
                {
                    if (input[x] > input[a])
                    {
                        temp = input[a];
                        input[a] = input[x];
                        input[x] = temp;
                    }
                    x++;
                }
            }
            return input;
        }
    }
}
