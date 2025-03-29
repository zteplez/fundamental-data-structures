using System;

namespace FundamentalDataStructures;

public class CustomLinkedList<T>
{
    internal class Node<T>{
        T value;
        Node<T>? nextNode;
        Node<T>? prevNode;
        public Node<T> NextNode {get => nextNode;}
        public Node(T value)
        {
            this.value = value;
            nextNode = null;
            prevNode = null;
        }
    }

    Node<T>? firstNode;
    Node<T>? lastNode;
    int count;
    public CustomLinkedList()
    {
        firstNode = null;
        lastNode = null;
    }
    public void Insert(T value){
        if(firstNode == null){
            firstNode = new Node<T>(value);
            Console.WriteLine("New node created on head.");
        }else{
            Node<T> iterator = firstNode;
            while(iterator.NextNode != null){
                
            }
        }
    }
}
