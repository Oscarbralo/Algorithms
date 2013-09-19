using System;

namespace BinarySearch
{
    public class BinarySearch
    {
        public string BinarySeach(int[] input, int value)
        {
            int search = value;
            int i = 0;
            int j = input.Length - 1;
            int index = -1;
            bool found = false;
            while (i <= j)
            {
                index = i + ((j - i) / 2);
                if (input[index] == search)
                {
                    found = true;
                    break;
                }
                index = (j + i) / 2;
                if (input[index] < search)
                    i = index + 1;
                else
                    j = index;
            }
            if (input.Length < 1 || found == false)
                return "This value doesn´t exist";
            else
                return "The index of this value is: " + index.ToString();
        }
    }
}
