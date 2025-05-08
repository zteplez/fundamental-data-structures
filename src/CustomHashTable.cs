using FundamentalDataStructures;

public class CustomHashTable
{
    // Example key-value pair -> "ibrahim as", 201, <string,int>
    public class Node
    {
        string key;
        int value;
        public Node(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
    CustomList<Node>[] buckets;

    public CustomHashTable()
    {
        buckets = new CustomList<Node>[10];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new CustomList<Node>();
        }
    }

}