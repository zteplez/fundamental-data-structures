class CustomBinarySearchTree
{
    internal class Node{
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
    public void CreateNode(int val){
        Node newNode = new Node(val);
        
        if(root == null){
            root = newNode;
            return;
        }
        InsertNode(newNode, root);
    }
    public void InsertNode(Node newNode, Node currNode){
       if(newNode.value < currNode.value){
            if(currNode.left == null){
                currNode.left = newNode;
                return;
            }
            InsertNode(newNode, currNode.left);
        }
        else if(newNode.value > currNode.value){
            if(currNode.right == null){
                currNode.right = newNode;
                return;
            }
            InsertNode(newNode, currNode.right);
        }else{
            currNode.left = newNode; // What should I do when values are equal ?
        }
    }
}