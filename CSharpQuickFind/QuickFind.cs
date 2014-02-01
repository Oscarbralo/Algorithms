using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFind
{
    public class QuickFind
    {
        private int[] id;

        //Initialize the quick find data structure
        public QuickFind(int n)
        {
            int count = -1;
            id = new int[n].Select(x => x = ++count).ToArray<int>();
        }

        //Join two components
        public void union(int p, int q)
        {
            id = (id[p] != id[q]) ? id.Select(x => (x == id[p]) ? x = id[q] : x).ToArray<int>() : id;
        }

        //CHeck if two components are connected
        public bool areConnected(int p, int q)
        {
            return (id[p] == id[q]) ? true : false;
        }

        //Count the number of connected components
        public int countComponents()
        {
            return id.Distinct().Count();
        }
    }
}
