using MyLinkedList;


LinkedList list = new LinkedList(new int[] { 5, 1, 2, 3, 4, 1 });

list.SelectionSort(false);
Console.WriteLine(list);

LinkedList list2 = new LinkedList(new int[] { 5, 1, 2, 3, 4, 1 });
list.AddToEndList(list2);
Console.WriteLine(list);
