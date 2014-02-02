using System.Linq;

namespace QuickUnion
{
    public class WeightedQuickUnionAlgorithm
    {
        private int[] id;

        //Initialize the quick union data structure
        public WeightedQuickUnionAlgorithm(int n)
        {
            int count = -1;
            id = new int[n].Select(x => x = ++count).ToArray<int>();
        }

        //Join the components, finding the root of p and q
        public void Union(int p, int q)
        {
            if (countComponentsOfARoot(p) >= countComponentsOfARoot(q))
                id[FindRoot(p)] = id[FindRoot(q)];
            else
                id[FindRoot(q)] = id[FindRoot(p)];
        }

        //Find the root of an element
        public int FindRoot(int i)
        {
            while (id[i] != i)
                i = id[i];
            return i;
        }

        //Check if two components are connected
        public bool AreConnected(int p, int q)
        {
            return id[p] == id[q];
        }

        //Count the number of components
        public int CountComponents()
        {
            int count = -1;
            return this.id.Where(x => x == ++count).Count();
        }

        //Count the number of elements in the same root
        public int countComponentsOfARoot(int i)
        {
            return this.id.Where(x => x == id[i]).Count();
        }
    }
}
