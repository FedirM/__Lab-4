using System;
using System.Collections.Generic;
using System.Linq;

namespace RB_Tree
{
    public class Explorer
    {
        public class CmpInt: IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if( x < y)
                {
                    return 1;
                } else if( x >= y)
                {
                    return -1;
                } else
                {
                    return 0;
                }
            }
        }


        public static void Main()
        {
            
            int[] arr = { 1, 8, 5, 7, 0, 66, 3, 4, 9 };
            int[] b = { 1, 66, 88, 33, 22 };
            IEnumerable<int> setA = null;

            Select obj = new Select();
            IEnumerable<int> set;

            set = obj.SelectIntersection(setA, b, new CmpInt());

            Console.Write("\nIntersection size: {0}", set.Count<int>());

            foreach (int elem in set)
            {
                Console.Write("\n ELEM: {0}", elem);
            }

            Console.Read();

        }
    }
}
