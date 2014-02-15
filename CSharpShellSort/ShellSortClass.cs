namespace ShellShort
{
    public class ShellSortClass
    {
        public int[] Sort(int[] input)
        {
            int totalLength = input.Length;

            int hSort = 1;
            while (hSort < totalLength / 3)
                hSort = (3 * hSort) + 1;

            while (hSort >= 1)
            {
                for (int i = hSort; i < totalLength; i++)
                {
                    for (int a = i; a >= hSort && (input[a] < input[a - hSort]); a -= hSort)
                    {
                        int temp = input[a];
                        input[a] = input[a - hSort];
                        input[a - hSort] = temp;
                    }
                }
                hSort /= 3;
            }
            return input;
        }
    }
}
