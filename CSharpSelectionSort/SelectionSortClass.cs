using System.Linq;

namespace SelectionSort
{
    public class SelectionSortClass
    {
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int min = 1000000000;
                int minIndex = -1;
                for (int a = i + 1; a < input.Length; a++)
                {
                    if (input[a] < input[i] && input[a] < min)
                    {
                        min = input[a];
                        minIndex = a;
                    }
                }
                if (minIndex != -1)
                {
                    int temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }
            }
            return input;
        }
    }
}
