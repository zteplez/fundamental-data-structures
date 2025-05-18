using System;

namespace FundamentalDataStructures.src;

public class CustomPriorityQueue
{
    public class Node
    {
        public string? value;
        public int priority;
        public Node(string value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }
    }
    public Node[] minHeap;
    int nodeCount;
    public CustomPriorityQueue()
    {
        minHeap = new Node[20];
        nodeCount = 0;
    }
    public void Enqueue(string value, int priority)
    {
        if (nodeCount >= minHeap.Length)
        {
            Console.WriteLine("Queue is full, cannot add more elements.");
            return;
        }

        minHeap[nodeCount] = new Node(value, priority);
        BubbleUp(nodeCount);
        nodeCount++;

        Console.WriteLine($"Added element: {value} with priority {priority}");
    }

    public void BubbleUp(int index)
    {
        if (index == 0) return;

        int parentIndex = (index - 1) / 2;

        if (minHeap[parentIndex].priority > minHeap[index].priority)
        {
            Node temp = minHeap[parentIndex];
            minHeap[parentIndex] = minHeap[index];
            minHeap[index] = temp;

            BubbleUp(parentIndex);
        }
        
    }
    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty, nothing to dequeue.");
            return;
        }

        minHeap[0] = minHeap[nodeCount - 1];

        minHeap[nodeCount - 1] = null;

        nodeCount--;

        if (!IsEmpty())
        {
            BubbleDown(0);
        }
    }
    public void BubbleDown(int index)
    {
        int leftChildIndex = 2 * index + 1;
        int rightChildIndex = 2 * index + 2;
        int smallestIndex = index;

        if (leftChildIndex < nodeCount && minHeap[leftChildIndex].priority < minHeap[smallestIndex].priority)
        {
            smallestIndex = leftChildIndex;
        }

        if (rightChildIndex < nodeCount && minHeap[rightChildIndex].priority < minHeap[smallestIndex].priority)
        {
            smallestIndex = rightChildIndex;
        }

        if (smallestIndex != index)
        {
            Node temp = minHeap[index];
            minHeap[index] = minHeap[smallestIndex];
            minHeap[smallestIndex] = temp;

            BubbleDown(smallestIndex);
        }
    }
    public Node Peek()
    {
        if (!IsEmpty())
        {
            return minHeap[0];
        }
        else
        {
            Console.Write("Empty heap!");
            return null;
        }
    }
    public void Resize()
    {

    }
    public bool IsEmpty() => nodeCount == 0;
    public int Count() => nodeCount;
    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < nodeCount; i++)
        {
            result += $"[{minHeap[i].priority}:{minHeap[i].value}] ";
        }
        return result.Trim();
    }

}
