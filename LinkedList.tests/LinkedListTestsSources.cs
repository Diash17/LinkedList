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
    internal class ChangeNodeByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 0, 1, 3, 3, 4, 5 });
            int value = 3;
            int index = 2;
            yield return new object[] { list, expected, value, index };

            list = new LinkedList(new int[] { 0, 1, 3, 3, 4, 5 });
            expected = new LinkedList(new int[] { 0, 0, 3, 3, 4, 5 });
            value = 0;
            index = 1;
            yield return new object[] { list, expected, value, index };

        }
    }
    internal class DeleteAndGetIndexFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 0, 1, 2, 4, 5 });
            int value = 3;
            int result = 3;
            yield return new object[] { list, expected, value, result };

            list = new LinkedList(new int[] { 0, 1, 3, 3, 4, 5 });
            expected = new LinkedList(new int[] { 0, 1, 3, 4, 5 });
            value = 3;
            result = 2;
            yield return new object[] { list, expected, value, result };

        }
    }
    internal class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 0, 0, 0, 0, 2, 3 });
            LinkedList expected = new LinkedList(new int[] { 2, 3 });
            int value = 0;
            yield return new object[] { list, expected, value };

            list = new LinkedList(new int[] { 0, 1, 3, 3, 4, 5 });
            expected = new LinkedList(new int[] { 0, 1, 4, 5 });
            value = 3;
            yield return new object[] { list, expected, value };

        }
    }
    internal class AddToEndListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 123, 456 });
            LinkedList listSec = new LinkedList(new int[] { 789, 10 });
            LinkedList expected = new LinkedList(new int[] { 123, 456, 789, 10 });
            yield return new object[] { listSec, list, expected };

        }
    }
    internal class AddToStartListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 4, 3, 2, 1 }); 
            LinkedList listSec = new LinkedList(new int[] { 9, 8, 7, 6, 5 });
            LinkedList expected = new LinkedList(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            yield return new object[] { listSec, list, expected };

            list = new LinkedList(new int[] { 6, 7, 8, 9, 10 });
            listSec = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            yield return new object[] { listSec, list, expected };

        }
    }
    internal class AddByIndexListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            LinkedList list = new LinkedList(new int[] {6,6,6,8,8,8 }); 
            LinkedList listSec = new LinkedList(new int[] { 7,7,7 });
            LinkedList expected = new LinkedList(new int[] {6,6,6,7,7,7,8,8,8 });
            yield return new object[] { listSec, list, expected, index };

        }
    }
}