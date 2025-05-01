using System;

namespace FundamentalDataStructures;

public class CustomList<T>
{
    T[] array;
    int _capacity = 10;
    int _currentIndex;
    public int Count { get => _currentIndex; }
    public int Capacity { get => _capacity; }
    public CustomList()
    {
        array = new T[_capacity];
        _currentIndex = 0;
    }

    public void Add(T element)
    {
        if (_currentIndex < _capacity)
        {
            array[_currentIndex++] = element;
        }
        else
        {
            DoubleUp();
            array[_currentIndex++] = element;
        }
    }
    public T Get(int index)
    {
        if (index >= 0 && index < _currentIndex)
        {
            return array[index];
        }
        throw new IndexOutOfRangeException("Index out of bounds.");
    }
    public void Clear()
    {
        Array.Clear(array, 0, _currentIndex);
        Console.WriteLine("List cleared.");
    }
    public void RemoveAt(int index)
    {
        if (index >= 0 && index < _currentIndex)
        {
            for (int i = 0; i < _currentIndex - 1; i++)
            {
                array[i] = array[i + 1]; 
            }
            _currentIndex--;
            array[_currentIndex] = default;
            Console.WriteLine("Element removed.");
        }else{
            Console.WriteLine("Invalid index.");
        }
    }
    public void DoubleUp()
    {
        T[] newArray = new T[_capacity * 2];

        for (int i = 0; i < _capacity; i++)
        {
            newArray[i] = array[i];
        }

        _capacity *= 2;
        array = newArray;
        Console.WriteLine("List grew.");
    }
    public void PrintList()
    {
        foreach (var item in array)
        {
            Console.WriteLine($"Element value -> {item}");
        }
    }

}
