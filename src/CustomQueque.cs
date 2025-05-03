public class CustomQueue<T>
{
    T[] queue;
    int front;
    int rear;
    int size;
    public CustomQueue()
    {
        queue = new T[10];
        front = 0;
        rear = -1;
        size = 0;
    }
    public void Enqueue(T item)
    {
        if (size == queue.Length)
        {
            Console.WriteLine("Full queque.");
            return;
        }
        rear = (rear + 1) % queue.Length;
        queue[rear] = item;
        size++;
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queque is empty.");
            return default;
        }
        T item = queue[front];
        front = (front + 1) % queue.Length;
        size--;
        return item;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queque is empty.");
            return default;
        }
        return queue[front];
    }
    public bool IsEmpty()
    {
        return size == 0;
    }
    public int GetSize() { return size; }
    public void Clear()
    {
        front = 0;
        rear = -1;
        size = 0;
        for (int i = 0; i < queue.Length; i++)
        {
            queue[i] = default;
        }
    }
    public override string ToString()
    {
        if (IsEmpty()) return "Queue is empty.";

        string result = "";
        for (int i = 0; i < size; i++)
        {
            int index = (front + i) % queue.Length;
            result += queue[index] + Environment.NewLine;
        }

        return result;
    }


}