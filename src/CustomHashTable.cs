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
        buckets = new CustomList<Node>[13];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new CustomList<Node>();
        }
    }
    public int Hash(string key){
        int hash = 0;
        for(int i = 0; i < key.Length; i++){
            hash += key[i];
        }
        Console.WriteLine("hash -> " + hash % 13);
        return hash % 13;
    }

}