using System;

namespace FundamentalDataStructures.src;

public class CustomPriorityQueue
{
    public class Node
    {
        string? value;
        public int priority;
        public Node(string value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }
    }
    public Node[] minHeap;

    public CustomPriorityQueue()
    {
        minHeap = new Node[20];
    }
    public void Enqueue(string value, int priority)
    {
        for (int i = 0; i < minHeap.Length; i++)
        {
            if (minHeap[i] == null)
            {
                minHeap[i] = new Node(value, priority);
                BubbleUp(i);
                Console.WriteLine("Add element.");
                return;
            }
        }
        Console.WriteLine("Element couldn't add.");
    }
    public void BubbleUp(int index)
    {
        if (index == 0) return;

        int parentIndex = (index - 1) / 2;
        Node parent = minHeap[parentIndex];
        Node currentElement = minHeap[index];

        if (parent.priority > currentElement.priority)
        {
            minHeap[parentIndex] = currentElement;
            minHeap[index] = parent;
            BubbleUp(parentIndex);
        }
    }
    public void BuildHeap()
    {

    }
    public void PrintArray()
    {
        foreach (var element in minHeap)
        {
            Console.Write($" {element} ");
        }
    }
    public void PrintHeap(int i)
    {
        Console.Write($"Root -> {minHeap[0]}");
        Console.Write($"Left -> {minHeap[1]}");
        Console.Write($"Right -> {minHeap[2]}");

        int parent = (i - 1) / 2;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
    }
}
/*
Parent: i → (i - 1) / 2
Left child: i → 2i + 1
Right child: i → 2i + 2*/