using FundamentalDataStructures;

LinkedList<int> a = new LinkedList<int>();

CustomLinkedList<int> list = new CustomLinkedList<int>();
list.Insert(15);
list.Insert(45);
list.Insert(25);
list.Insert(35);

list.TraverseFromFirst();

list.Remove(22);
CustomLinkedList.Node<int> a = list.Get(15);