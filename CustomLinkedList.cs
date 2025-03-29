using System;

namespace FundamentalDataStructures;

public class LinkedList
{
    internal class Node<T>{
        T value;
        Node<T>? nextNode;
        Node<T>? prevNode;
        public Node(T value)
        {
            this.value = value;
            nextNode = null;
            prevNode = null;
        }
    }
}
