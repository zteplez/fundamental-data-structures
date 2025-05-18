using System;

namespace FundamentalDataStructures.src;

public class CustomPriorityQueue
{
    public class Node
    {
        string? value;
        int priority;
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
                break;
            }
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
Right child: i → 2i + 2
*/