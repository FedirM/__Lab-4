using System;
using System.Collections.Generic;
using System.Linq;

namespace RB_Tree
{
    public class Select
    {
        public IEnumerable<int> SelectIntersection(IEnumerable<int> setA, IEnumerable<int> setB, IComparer<int> comparer)
        {
            var res = new List<int>();
            int elem;

            if(setB == null || setA == null || setA.Count<int>() == 0 || setB.Count<int>() == 0 )
            {
                return res;
            }

            RedBlackTree<int> tree = new RedBlackTree<int>(comparer);

            foreach (int item in setA)
            {
                tree.Insert(item, DuplicatePolicy.DoNothing, out elem);
            }

            foreach(int item in setB)
            {
                for(int indx = 0; indx < tree.ElementCount; indx++)
                {
                    if( tree.GetItemByIndex(indx) == item)
                    {
                        res.Add(item);
                    }
                }
            }
            return res;
        }
    }
}
