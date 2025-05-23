using System;

namespace FundamentalDataStructures;

public class CustomLinkedList<T>
{
    public class Node<T>
    {
        public T value;
        public Node<T>? nextNode;
        public Node<T>? prevNode;
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
    public void Insert(T value)
    {
        if (firstNode == null)
        {
            firstNode = new Node<T>(value);
            lastNode = firstNode;
            Console.WriteLine("New node created on head.");
        }
        else
        {
            Node<T> iterator = firstNode;
            while (iterator.nextNode != null)
            {
                iterator = iterator.nextNode;
            }
            Node<T> newNode = new Node<T>(value);
            iterator.nextNode = newNode;
            newNode.prevNode = iterator;
            lastNode = newNode;
            Console.WriteLine("New node created.");
        }
    }
    public void Remove(T value)
    {
        if (firstNode != null)
        {
            Node<T> iterator = firstNode;
            while (iterator != null)
            {
                if (EqualityComparer<T>.Default.Equals(iterator.value, value))
                {
                    Console.WriteLine("Element found.");
                    if (iterator == firstNode)
                    {
                        firstNode = iterator.nextNode;
                        iterator.prevNode = null;
                        iterator = null;
                    }
                    else if (iterator == lastNode)
                    {
                        lastNode = iterator.prevNode;
                        lastNode.nextNode = null;
                    }
                    else
                    {
                        iterator.prevNode.nextNode = iterator.nextNode;
                        iterator.nextNode.prevNode = iterator.prevNode;
                    }
                    return;
                }
                iterator = iterator.nextNode;
            }
            Console.WriteLine("Element is not in list.");
        }
        else
        {
            Console.WriteLine("Empty list.");
        }
    }
    public Node<T> Get(T value)
    {
        if (firstNode != null)
        {
            Node<T>? iterator = firstNode;
            while (iterator != null)
            {
                if (EqualityComparer<T>.Default.Equals(iterator.value, value))
                {
                    Console.WriteLine("Found element");
                    return iterator;
                }
                iterator = iterator.nextNode;
            }
            Console.WriteLine("Empty list.");
            return new Node<T>(default);
        }
        Console.WriteLine("Element is not in list.");
        return new Node<T>(default);
    }
    public void TraverseFromFirst()
    {
        if (firstNode != null)
        {
            Node<T> iterator = firstNode;
            while (iterator.nextNode != null)
            {
                Console.WriteLine($"Value {iterator.value}");
                iterator = iterator.nextNode;
            }
            Console.WriteLine($"Last node value {iterator.value}");
        }
        else
        {
            Console.WriteLine("Empty list.");
        }

    }
    public void TraverseFromLast()
    {
        if (lastNode != null)
        {
            Node<T> iterator = lastNode;
            while (iterator.prevNode != null)
            {
                Console.WriteLine($"Value {iterator.value}");
                iterator = iterator.prevNode;
            }
            Console.WriteLine($"First node value {iterator.value}");
        }
        else
        {
            Console.WriteLine("Empty list.");
        }
    }
}
