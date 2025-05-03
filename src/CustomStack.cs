using System;
using System.Linq.Expressions;

namespace FundamentalDataStructures.src;

public class CustomStack<T>
{
    T[] stack;
    int count;
    int top;
    const int BASE_CAPACITY = 10;

    public CustomStack()
    {
        stack = new T[BASE_CAPACITY];
        count = 0;
        top = -1;
    }

    public void Push(T element)
    {
        if (count == stack.Length)
        {
            Console.WriteLine("Stack is full. It's gonna dynamically grow.");
            GrowStack();
        }

        stack[++top] = element;
        count++;
    }
    public void Pop()
    {
        if (top != -1)
        {
            stack[top] = default(T);
            top--;
            count--;
            return;
        }
        Console.WriteLine("Empty stack.");
    }
    public T? Peek()
    {
        if (top != -1)
        {

            return stack[top];
        }
        return default;
    }
    public bool IsEmpty()
    {
        return count == 0 ? true : false;
    }
    public int Size() { return count; }
    public void Clear()
    {
        for (int i = 0; i < stack.Length; i++)
        {
            stack[i] = default(T);
        }
        top = -1;
        count = 0;
    }
    public override string ToString()
    {
        if (IsEmpty()) return "Stack is empty.";

        string result = "";
        for (int i = top; i >= 0; i--)
        {
            result += stack[i] + Environment.NewLine;
        }
        return result;
    }

    public void GrowStack()
    {
        int newCapacity = stack.Length * 2;
        T[] newArr = new T[newCapacity];
        Array.Copy(stack, newArr, stack.Length);
        stack = newArr;

    }
}
