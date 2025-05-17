using FundamentalDataStructures;

public class CustomHashTable
{
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
        if (!CheckKeyExists(newNode))
        {
            int index = Hash(key);
            buckets[index].Add(newNode);
        }
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
    public double CalculateLoadFactor()
    {
        double n = 0;
        double m = 13;
        foreach (var item in buckets)
        {
            n += item.Count;
        }
        double a = Math.Round(n / m, 2);
        Console.WriteLine($"n is {n} and m is {m}");
        Console.WriteLine($"Load factor {a}");
        return a;
    }
    private bool CheckKeyExists(Node target)
    {

        for (int i = 0; i < buckets.Length; i++)
        {
            CustomList<Node> curr = buckets[i];
            if (curr.Count != 0)
            {
                for (int j = 0; j < curr.Count; j++)
                {
                    if (curr.Get(j).key == target.key)
                    {
                        curr.Get(j).value = target.value;
                        Console.WriteLine($"Key exists, change value -> {target.value}");
                        return true;
                    }
                }
            }
        }
        return false;
    }
}