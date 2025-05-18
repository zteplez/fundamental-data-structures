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
        for (int i = 0; i < minHeap.Length; i++)
        {
            if (minHeap[i] == null)
            {
                nodeCount++;
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
    public void Dequeue()
    {
        if (minHeap[0] != null)
        {
            minHeap[0] = minHeap[nodeCount];
            BubbleDown(0);
            nodeCount--;
        }
    }
    public void BubbleDown(int index)
    {
        int leftIndex = 2 * index + 1;
        int rightIndex = 2 * index + 2;
        int smallest = index;

        if (leftIndex < nodeCount && minHeap[leftIndex].priority < minHeap[smallest].priority)
        {
            smallest = leftIndex;
        }

        if (rightIndex < nodeCount && minHeap[rightIndex].priority < minHeap[smallest].priority)
        {
            smallest = rightIndex;
        }

        if (smallest != index)
        {
            Node temp = minHeap[index];
            minHeap[index] = minHeap[smallest];
            minHeap[smallest] = temp;

            BubbleDown(smallest);
        }
    }
    public Node Peek()
    {
        if (minHeap[0] != null)
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
}
