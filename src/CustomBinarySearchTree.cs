class CustomBinarySearchTree
{
    class Node{
        Node? left;
        Node? right;
        int root;
        public Node(int value)
        {
            root = value;
            left = null;
            right = null;
        }
    }
    Node root;
    public CustomBinarySearchTree(int rootValue)
    {
        root = new Node(rootValue);
    }
    public void Insert(){
        
    }
}