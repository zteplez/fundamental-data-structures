class CustomBinarySearchTree
{
    internal class Node
    {
        internal Node? left;
        internal Node? right;
        internal int value;
        public Node(int val)
        {
            value = val;
            left = null;
            right = null;
        }
    }
    Node root;
    public CustomBinarySearchTree(int rootValue)
    {
        root = new Node(rootValue);
    }
    public void CreateNode(int val)
    {
        Node newNode = new Node(val);

        if (root == null)
        {
            root = newNode;
            return;
        }
        InsertNode(newNode, root);
    }
    public void InsertNode(Node newNode, Node currNode)
    {
        if (newNode.value < currNode.value)
        {
            if (currNode.left == null)
            {
                currNode.left = newNode;
                return;
            }
            InsertNode(newNode, currNode.left);
        }
        else if (newNode.value > currNode.value)
        {
            if (currNode.right == null)
            {
                currNode.right = newNode;
                return;
            }
            InsertNode(newNode, currNode.right);
        }
        else
        {
            currNode.left = newNode; // What should I do when values are equal ?
        }
    }
    public Node Find(int targetValue)
    {
        if (root == null)
        {
            Console.WriteLine("Empty tree.");
            return null;
        }

        Node targetNode = FindNode(targetValue, root);
        if (targetNode == null)
        {
            Console.WriteLine("Cannot find target node.");
            return null;
        }
        else
        {
            return targetNode;
        }
    }
    private Node FindNode(int targetValue, Node currentNode)
    {
        if (targetValue < currentNode.value)
        {
            if (currentNode.left != null)
            {
                FindNode(targetValue, currentNode.left);
            }
            else
            {
                return null;
            }
        }
        else if (targetValue > currentNode.value)
        {
            if (currentNode.right != null)
            {
                FindNode(targetValue, currentNode.right);
            }
            else
            {
                return null;
            }
        }
        else
        {
            return currentNode;
        }
        return null;
    }
    public void PrintInOrder()
    {
        if (root == null)
        {
            Console.WriteLine("Tree is empty.");
            return;
        }
        InOrderTraversal(root);
    }
    public void InOrderTraversal(Node currentNode)
    {
        if (currentNode.left != null)
        {
            InOrderTraversal(currentNode.left);

        }
        Console.WriteLine("Value -> " + currentNode.value);

        if (currentNode.right != null)
        {
            InOrderTraversal(currentNode.right);
        }
    }
    public void DeleteNode(int value)
    {
        root = DeleteNodeRecursive(root, value);
    }
    public Node DeleteNodeRecursive(Node current, int targetValue)
    {
        if (current == null)
            return null;

        if (targetValue < current.value)
        {
            current.left = DeleteNodeRecursive(current.left, targetValue);
        }
        else if (targetValue > current.value)
        {
            current.right = DeleteNodeRecursive(current.right, targetValue);
        }
        else
        {
            if (current.left == null && current.right == null)
            {
                return null;
            }

            if (current.left == null)
            {
                return current.right;
            }
            else if (current.right == null)
            {
                return current.left;
            }

            Node successor = FindMin(current.right);
            current.value = successor.value;
            current.right = DeleteNodeRecursive(current.right, successor.value);
        }

        return current;
    }

    private Node FindMin(Node node)
    {
        while (node.left != null)
        {
            node = node.left;
        }
        return node;
    }



}