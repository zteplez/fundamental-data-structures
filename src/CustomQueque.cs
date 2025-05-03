public class CustomQueque<T>
{
    T[] queque;
    int front;
    int rear;
    int size;
    public CustomQueque()
    {
        queque =  new T[10];
        front = -1;
        rear = -1;
        size = 0;
    }
}