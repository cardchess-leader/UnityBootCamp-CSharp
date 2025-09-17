class BstNode
{
    public int Key;
    public BstNode? Left;
    public BstNode? Right;

    public BstNode(int key)
    {
        Key = key;
    }
}

class BinarySearchTree
{
    private BstNode? _root;

    public void Insert(int key)
    {
        _root = InsertRec(_root, key);
    }

    private BstNode InsertRec(BstNode? node, int key)
    {
        if (node == null)
            return new BstNode(key);

        if (key < node.Key)
            node.Left = InsertRec(node.Left, key);

        if (key > node.Key)
            node.Right = InsertRec(node.Right, key);

        return node;
    }

    public bool Contains(int key)
    {
        var now = _root;
        while (now != null)
        {
            if (key == now.Key)
                return true;

            now = (key < now.Key) ? now.Left : now.Right;
        }

        return false;
    }

    public BstNode? Find(int key)
    {
        var now = _root;
        while (now != null)
        {
            if (key == now.Key)
                return now;

            now = (key < now.Key) ? now.Left : now.Right;
        }

        return null;
    }

    public void Remove(int key)
    {
        _root = RemoveRec(_root, key);
    }

    private BstNode? RemoveRec(BstNode? node, int key)
    {
        if (node == null)
            return null;

        if (key < node.Key)
        {
            node.Left = RemoveRec(node.Left, key);
        }
        else if (key > node.Key)
        {
            node.Right = RemoveRec(node.Right, key);
        }
        else
        {
            if (node.Left == null && node.Right == null)
                return null;

            if (node.Left == null)
                return node.Right;
            if (node.Right == null)
                return node.Left;

            BstNode min = FindMin(node.Right);
            node.Key = min.Key;
            node.Right = RemoveRec(node.Right, min.Key);
        }

        return node;
    }

    private BstNode FindMin(BstNode node)
    {
        while (node.Left != null)
            node = node.Left;

        return node;
    }
}