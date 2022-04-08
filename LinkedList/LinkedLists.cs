using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyLinkedList
{
    public class LinkedList
    {
        private Node _root;
        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }
            set
            {

            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }
                return count;
            }
            private set
            {
            }
        }
        public LinkedList()
        {
            _root = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }
        public LinkedList(int[] array)
        {
            _root = null;
            _tail = null;
            for (int i = 0; i < array.Length; i++)
            {
                this.AddToEnd(array[i]);
            }
        }

        public void AddToEnd(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }
        public void AddToBeginning(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }
        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the array");
            }
            if (_root == null && index == 0)
            {
                AddToBeginning(value);
            }
            else
            {
                Node prev = null;
                Node crnt = _root;
                int i = 0;
                Node newNode = new Node(value);
                while (i != index)
                {
                    prev = crnt;
                    crnt = crnt.Next;
                    i++;
                }
                prev.Next = newNode;
                newNode.Next = crnt;
            }
        }
        public void DeleteLast()
        {
            if (_tail is null)
            {
                throw new Exception("nothing to delete");
            }
            int length = Length;
            if (length < 2)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node prev = GetNode(Length - 2);
                prev.Next = null;
                _tail = prev;
            }
        }
        public void DeleteFirst()
        {
            if (_root is null)
            {
                throw new Exception("nothing to delete");
            }
            int length = Length;
            _root = _root.Next;
        }
        public void DeleteByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the array");
            }

            if (_root is null)
            {
                throw new Exception("nothing to delete");
            }
            Node prev = GetNode(index - 1);
            Node crnt = GetNode(index);
            crnt = crnt.Next;
            prev.Next = crnt;
            if (index == 0)
            {
                DeleteFirst();
            }
        }

        public void DeleteLastNElements(int count)
        {
            if (count > Length || count <= 0)
            {
                throw new Exception("cannot delete ");
            }
            if (count == Length)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node crnt = GetNode(Length - count - 1);
                crnt.Next = null;
                _tail = crnt;
            }
        }
        public void DeleteFirstNElements(int count)
        {
            if (count > Length || count <= 0)
            {
                throw new Exception("cannot delete ");
            }
            for (int i = 0; i != count; i++)
            {
                DeleteFirst();
            }
        }
        public void DeleteNElementsByIndex(int count, int index)
        {
            if (count > Length || count < 0 ||
                index < 0 || index >= Length ||
                index + count > Length)
            {
                throw new Exception("cannot delete ");
            }

            Node start = GetNode(index - 1);
            Node end = GetNode(index + count);
            start.Next = end;
        }

        public Node GetNode(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt;
        }
        public int GetFirstIndexByValue(int value)
        {
            if (_root is null || _tail is null)
            {
                throw new Exception("empty");
            }
            Node crnt = _root;
            int index = -1;
            for (int i = 0; crnt != null; i++)
            {
                if (value == crnt.Value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        public void ChangeNodeByIndex(int index, int value)
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to change");
            }
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            Node crnt = GetNode(index);
            crnt.Value = value;
        }
        public void Reverse()
        {
            if (_tail is null)
            {
                throw new Exception();
            }

            Node crnt = _root;
            Node prev = null;
            Node next = null;
            while (crnt.Next != null)
            {
                next = crnt.Next;
                crnt.Next = prev;
                prev = crnt;
                crnt = next;
            }
            crnt.Next = prev;
            _root = crnt;
        }
        public int FindMax()
        {
            if (_tail is null)
            {
                throw new Exception("nothing to find");
            }
            Node maxNode = GetNode(0);
            int max = maxNode.Value;
            for (int i = 1; i < Length; i++)
            {
                maxNode = GetNode(i);
                if (max < maxNode.Value)
                {
                    max = maxNode.Value;
                }
            }
            return max;
        }
        public int FindMin()
        {
            if (_tail is null)
            {
                throw new Exception("nothing to find");
            }
            Node minNode = GetNode(0);
            int min = minNode.Value;
            for (int i = 1; i < Length; i++)
            {
                minNode = GetNode(i);
                if (min > minNode.Value)
                {
                    min = minNode.Value;
                }
            }
            return min;
        }
        public int FindIndexOfMax()
        {
            if (_tail is null)
            {
                throw new Exception("nothing to find");
            }
            Node maxNode = GetNode(0);
            int max = maxNode.Value;
            int index = 0;
            int i = 0;
            for (i = 0; i < Length; i++)
            {
                maxNode = GetNode(i);
                if (max < maxNode.Value)
                {
                    max = maxNode.Value;
                    index = i;
                }
            }
            return index;
        }

        public int FindIndexOfMin()
        {
            if (_tail is null)
            {
                throw new Exception("nothing to find");
            }
            Node minNode = GetNode(0);
            int min = minNode.Value;
            int index = 0;
            int i = 0;
            for (i = 0; i < Length; i++)
            {
                minNode = GetNode(i);
                if (min > minNode.Value)
                {
                    min = minNode.Value;
                    index = i;
                }
            }
            return index;
        }
        /// <summary>
        /// Sort in ascending order by default
        /// </summary>
        /// <param name="descending">Sort in descending if set to true</param>
        public void SelectionSort(bool descending = false)
        {
            Node? crnt = _root;

            bool compare(int x, int y)
            {
                if (descending)
                {
                    return x > y;
                }
                else
                {
                    return x < y;
                }
            }

            while (crnt != null)
            {
                Node? minNode = crnt;
                Node? startNode = crnt;
                while (crnt.Next != null)
                {
                    if (compare(crnt.Next.Value, minNode.Value))
                    {
                        minNode = crnt.Next;
                    }
                    crnt = crnt.Next;
                }

                // swap
                int temp = startNode.Value;
                startNode.Value = minNode.Value;
                minNode.Value = temp;

                crnt = startNode.Next;
            }
        }
        public int DeleteAndGetIndexFirstByValue(int value)
        {
            int i = 0;
            int result = -1;
            Node crnt = _root;
            while (i < Length)
            {
                if (value == GetNode(i).Value)
                {
                    if (i == 0)
                    {
                        _root = crnt.Next;
                        break;
                    }
                    else
                    {
                        result = i;
                        break;
                    }
                }
                else
                {
                    i++;
                }
            }
            GetNode(i - 1).Next = GetNode(i + 1);
            return result;
        }
        public void DeleteAllByValue(int value)
        {
            int index = 0;
            Node crnt = _root;
            int count = 0;
            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    if (index == 0)
                    {
                        _root = crnt.Next;
                        count++;
                        index--;
                    }
                    else
                    {
                        Node prev = GetNode(index - 1);
                        prev.Next = crnt.Next;
                        count++;
                        index--;
                    }
                }
                index++;
                crnt = crnt.Next;
            }
        }
        public void AddToEndList(LinkedList listSecond)
        {
            if (this == listSecond)
            {
                throw new ArgumentException("Cannot append itself to itself");
            }
            _tail.Next = listSecond._root;
            _tail = listSecond._tail;
        }
        public void AddToStartList(LinkedList listSecond)
        {
            if (this == listSecond)
            {
                throw new ArgumentException("Cannot append itself to itself");
            }
            listSecond._tail.Next = _root;
            _root= listSecond._root;
        }
        public void AddByIndexList(LinkedList listSecond, int index)
        {
            if (this == listSecond)
            {
                throw new ArgumentException("Cannot append itself to itself");
            }
            Node second = GetNode(index);
            Node prev = GetNode(index - 1);
            prev.Next = listSecond._root;
            listSecond._tail=second;
            ///не так работает
          
        }
        public override string ToString()
        {
            string str = "[ ";
            Node crnt = _root;
            while (crnt != null)
            {
                str += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            str += "]";

            return str;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }
            Node crnt = _root;
            Node crnt2 = list._root;
            while (crnt != null)
            {
                if (crnt.Value != crnt2.Value)
                {
                    return false;
                }
                crnt = crnt.Next;
                crnt2 = crnt2.Next;
            }

            return true;
        }
    }
}
