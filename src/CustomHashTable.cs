using FundamentalDataStructures;

public class CustomHashTable
{
    // Example key-value pair -> "ibrahim as", 201, <string,int>
    public class Node
    {
        public string key;
        public int value;
        public Node(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
        public override string ToString()
        {
            return $"Key: {key}, Value: {value}";
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
    public int Hash(string key)
    {
        int hash = 0;
        for (int i = 0; i < key.Length; i++)
        {
            hash += key[i];
        }
        Console.WriteLine("hash -> " + hash % 13);
        return hash % 13;
    }
    public void Put(string key, int value)
    {
        Node newNode = new Node(key, value);
        int index = Hash(key);
        buckets[index].Add(newNode); 
    }
    public void PrintTable()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            Console.Write(i + 1 + "Bucket -> ");
            PrintListTable(buckets[i]);
            Console.WriteLine("\n\n");
        }
    }
    public void PrintListTable(CustomList<Node> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.Get(i).ToString());
        }
    }

}