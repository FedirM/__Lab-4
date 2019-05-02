


using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RB_Tree;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestEmptySet()
        {
            int[] setA = { };
            int[] setB = { 1, 2, 3, 4 };

            IEnumerable<int> inter;

            Select obj = new Select();
            inter = obj.SelectIntersection(setA, setB, new Explorer.CmpInt());

            CollectionAssert.AreEqual(setA, inter.ToArray());
        }

        [TestMethod]
        public void TestEmptyIntersectionSet()
        {
            int[] setA = { 22, -5, 0, 32};
            int[] setB = { 1, 2, 3, 4 };
            int[] resIntersection = { };

            IEnumerable<int> inter = Enumerable.Empty<int>();

            Select obj = new Select();
            inter = obj.SelectIntersection(setA, setB, new Explorer.CmpInt());

            CollectionAssert.AreEqual(resIntersection, inter.ToArray());
        }
        [TestMethod]
        public void TestIntersectionSet()
        {
            int[] setA = { 22, 5, 0, 32 };
            int[] setB = { 1, 2, 3, 4, 0, 5 };
            int[] resIntersection = { 0, 5 };

            IEnumerable<int> inter = Enumerable.Empty<int>();

            Select obj = new Select();
            inter = obj.SelectIntersection(setA, setB, new Explorer.CmpInt());

            CollectionAssert.AreEqual(resIntersection, inter.ToArray());
        }
        [TestMethod]
        public void TestNullSet()
        {
            IEnumerable<int> setA = null;
            int[] setB = { 1, 2, 3, 4, 0, 5 };
            var resIntersection = new List<int>();

            IEnumerable<int> inter = Enumerable.Empty<int>();

            Select obj = new Select();
            inter = obj.SelectIntersection(setA, setB, new Explorer.CmpInt());

            CollectionAssert.AreEqual(resIntersection, inter.ToArray());
        }
    }
}
