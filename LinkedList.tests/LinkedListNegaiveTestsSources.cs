using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace MyLinkedList.tests
{
    internal class AddByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 4, 5, 6 });
            int value = 3;
            int index = 5;

            yield return new object[] { list, value, index };
        }
    }
    internal class DeleteFirstNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { });

            yield return new object[] { list };
        }
    }
    internal class DeleteByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 4, 5, 6 });
            int index = 5;
            yield return new object[] { list, index };
        }
    }
    internal class DeleteLastNElementsNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 4, 5, 6 });
            int count = -1;

            yield return new object[] { list, count };
        }
    }
    internal class DeleteFirstNElementsNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 4, 5, 6 });
            int count = -1;

            yield return new object[] { list, count };
        }
    }
    internal class DeleteNElementsByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            int count = -1;
            int index = 4;
            yield return new object[] { list, count, index };
        }
    }
}

