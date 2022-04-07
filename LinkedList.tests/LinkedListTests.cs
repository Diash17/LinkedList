using NUnit.Framework;
using System;

namespace MyLinkedList.tests
{
    public class LinkedListTest
    {
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(LinkedList list, LinkedList expected, int value, int index)
        {
            list.AddByIndex(index, value);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexNegativeTest_WhenIndexOutOfRange_ShouldThrowException(LinkedList list, int value, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(LinkedList list, LinkedList expected, int value)
        {
            list.AddToEnd(value);
            Assert.AreEqual(expected, list);
        }
        [TestCaseSource(typeof(AddToBeginningTestSource))]
        public void AddToBeginningTest(LinkedList list, LinkedList expected, int value)
        {
            list.AddToBeginning(value);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(LinkedList list, LinkedList expected)
        {
            list.DeleteLast();
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(LinkedList list, LinkedList expected)
        {
            list.DeleteFirst();
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(DeleteFirstNegativeTestSource))]
        public void DeleteFirstNegativeTest_WhenRootEqualZero(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(LinkedList list, LinkedList expected, int index)
        {
            list.DeleteByIndex(index);
            Assert.AreEqual(expected, list);
        }
        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndexNegativeTest_WhenIndexOutOfRangeException_ShouldThrowException(LinkedList list, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteLastNElementsTestSource))]
        public void DeleteLastNElementsTest(LinkedList list, LinkedList expected, int count)
        {
            list.DeleteLastNElements(count);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(DeleteLastNElementsNegativeTestSource))]
        public void DeleteLastNElementsNegativeTest_WhenCountOutOfList_ShouldThrowException(LinkedList list, int count)
        {
            Assert.Throws<Exception>(() => list.DeleteLastNElements(count));
        }

        [TestCaseSource(typeof(DeleteFirstNElementsTestSource))]
        public void DeleteFirstNElementsTest(LinkedList list, LinkedList expected, int count)
        {
            list.DeleteFirstNElements(count);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(DeleteFirstNElementsNegativeTestSource))]
        public void DeleteFirstNElementsNegativeTest_WhenCountOutOfList_ShouldThrowException(LinkedList list, int count)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstNElements(count));
        }

        [TestCaseSource(typeof(DeleteNElementsByIndexTestSource))]
        public void DeleteNElementsByIndexTest(LinkedList list, LinkedList expected, int count, int index)
        {
            list.DeleteNElementsByIndex(count, index);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(DeleteNElementsByIndexNegativeTestSource))]
        public void DeleteNElementsByIndexNegativeTest_WhenCountEqualZero_ShouldThrowException(LinkedList list, int count, int index)
        {
            Assert.Throws<Exception>(() => list.DeleteNElementsByIndex(count, index));
        }

        [TestCaseSource(typeof(GetFirstIndexByValueTestSource))]
        public void GetFirstIndexByValueTest(LinkedList list, int expected, int value)
        {
            int actual = list.GetFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkedList list, LinkedList expected)
        {
            list.Reverse();
            Assert.AreEqual(expected, list);
        }


        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(LinkedList list, int expected)
        {
            int actual = list.FindMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(LinkedList list, int expected)
        {
            int actual = list.FindMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SelectionSortTestSource))]
        public void SelectionSortTest(LinkedList list, LinkedList expected, bool descending)
        {
            list.SelectionSort(descending);
            Assert.AreEqual(expected, list);
        }
    }
}
