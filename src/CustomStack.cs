using System;

namespace FundamentalDataStructures.src;

public class CustomStack<T>
{
    CustomList<T> list;
    int count;
    int top;

    public CustomStack(){
        list = new CustomList<T>();
        count = 0; 
        top = -1;
    }

    public void Push(){}
    public void Pop(){}
    public T? Peek(){
        return default;
    }
    public bool IsEmpty(){
        return count == 0 ? true : false;
    }

}
