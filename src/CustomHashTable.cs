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
            hash = 31 * hash + key[i];
        }
        return Math.Abs(hash) % buckets.Length;
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
        int index = Hash(target.key);

        for (int i = 0; i < buckets[index].Count; i++)
        {
            if (buckets[index].Get(i).key == target.key)
            {
                buckets[index].Get(i).value = target.value;
                Console.WriteLine($"Key exists, change value -> {target.value}");
                return true;
            }
        }

        return false;
    }
    public int? Get(string targetKey)
    {
        int index = Hash(targetKey);

        for (int i = 0; i < buckets[index].Count; i++)
        {
            if (buckets[index].Get(i).key == targetKey)
            {
                Console.WriteLine($"Target key found: {targetKey}, Value: {buckets[index].Get(i).value}");
                return buckets[index].Get(i).value;
            }
        }
        Console.WriteLine("Key doesn't exists in bucket.");
        return null;
    }
    public bool Remove(string targetKey)
    {
        int index = Hash(targetKey);

        for (int i = 0; i < buckets[index].Count; i++)
        {
            if (buckets[index].Get(i).key == targetKey)
            {
                buckets[index].RemoveAt(i);
                Console.WriteLine("Target found and removed.");
                return true;
            }
        }
        Console.WriteLine("Key doesn't exists in bucket.");
        return false;
    }
}