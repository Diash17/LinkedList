using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.tests
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList list = new LinkedList(new int[] { 1, 2, 4, 5, 6 });
            int value = 3;
            int index = 2;

            yield return new object[] { list, expected, value, index };

        }
    }
    internal class AddToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int value = 6;

            yield return new object[] { list, expected, value };

        }
    }
    internal class AddToBeginningTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int value = 0;

            yield return new object[] { list, expected, value };

        }
    }
    internal class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4 });
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { list, expected };
        }
    }
    internal class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 2, 3, 4, 5 });
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { list, expected };
        }
    }
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 0, 1, 3, 4, 5 });
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            int index = 2;
            yield return new object[] { list, expected, index };

            expected = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            list = new LinkedList(new int[] { 7, 1, 2, 3, 4, 5 });
            index = 0;
            yield return new object[] { list, expected, index };

            expected = new LinkedList(new int[] { 0, 1, 2, 3, 4 });
            list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            index = 5;
            yield return new object[] { list, expected, index };
        }
    }
    internal class DeleteLastNElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 0, 1, 2, 3 });
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            int count = 2;
            yield return new object[] { list, expected, count };

            expected = new LinkedList(new int[] { });
            list = new LinkedList(new int[] { 1, 1, 2, 3, 4, 5 });
            count = 6;
            yield return new object[] { list, expected, count };
        }
    }
    internal class DeleteFirstNElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 2, 3, 4, 5 });
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            int count = 2;
            yield return new object[] { list, expected, count };

            expected = new LinkedList(new int[] { });
            list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            count = 6;
            yield return new object[] { list, expected, count };
        }
    }
    internal class DeleteNElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 0, 1, 4, 5 });
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            int count = 2;
            int index = 2;
            yield return new object[] { list, expected, count, index };

            expected = new LinkedList(new int[] { 0, 1, 5 });
            list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            count = 3;
            index = 2;
            yield return new object[] { list, expected, count, index };
        }
    }
    internal class GetFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 3;
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            int value = 3;
            yield return new object[] { list, expected, value };

            expected = 0;
            list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            value = 0;
            yield return new object[] { list, expected, value };

            expected = -1;
            list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            value = 9;
            yield return new object[] { list, expected, value };
        }
    }
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 5, 4, 3, 2, 1, 0 });
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            yield return new object[] { list, expected };
        }
    }
    internal class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 6;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int actual = list.FindMax();

            yield return new object[] { list, expected };
        }
    }
    internal class FindMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int actual = list.FindMin();

            yield return new object[] { list, expected };
        }
    }

    internal class FindIndexOfMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 0;
            LinkedList list = new LinkedList(new int[] { 9, 2, 3, 4, 5, 6 });
            int actual = list.FindIndexOfMax();

            yield return new object[] { list, expected };
        }
    }

    internal class FindIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int actual = list.FindIndexOfMin();

            yield return new object[] { list, expected };
        }
    }
    internal class SelectionSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            bool descending = false;
            LinkedList expected = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            LinkedList list = new LinkedList(new int[] { 5, 4, 3, 2, 1, 0 });
            yield return new object[] { list, expected, descending };

            descending = true;
            expected = new LinkedList(new int[] { 5, 4, 3, 2, 1, 0 });
            list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            yield return new object[] { list, expected, descending };
        }
    }
}