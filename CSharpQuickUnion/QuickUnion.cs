using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnion
{
    public class QuickUnionAlgorithm
    {
        private int[] id;

        //Initialize the quick union data structure
        public QuickUnionAlgorithm(int n)
        {
            int count = -1;
            id = new int[n].Select(x => x = ++count).ToArray<int>();
        }

        //Join the components, finding the root of p and q
        public void Union(int p, int q)
        {
            id[FindRoot(p)] = id[FindRoot(q)];
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
    }
}
