using System.Linq;

namespace QuickFind
{
    public class QuickFindAlgorithm
    {
        private int[] id;

        //Initialize the quick find data structure
        public QuickFindAlgorithm(int n)
        {
            int count = -1;
            id = new int[n].Select(x => x = ++count).ToArray<int>();
        }

        //Join two components
        public void Union(int p, int q)
        {
            id = (id[p] != id[q]) ? id.Select(x => (x == id[p]) ? x = id[q] : x).ToArray<int>() : id;
        }

        //CHeck if two components are connected
        public bool AreConnected(int p, int q)
        {
            return id[p] == id[q];
        }

        //Count the number of connected components
        public int CountComponents()
        {
            return id.Distinct().Count();
        }
    }
}