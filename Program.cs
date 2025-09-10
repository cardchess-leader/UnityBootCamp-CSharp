class CustomList
{
    private int[] items;
    public int count;
    public CustomList()
    {
        items = new int[1];
        count = 0;
    }
    public void Add(int item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count] = item;
        count++;
    }
    public bool Remove(int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        count--;
        return true;
    }
    public int Count
    {
        get { return count; }
    }
    private void Resize()
    {
        int newSize = items.Length * 2;
        int[] newItems = new int[newSize];
        for (int i = 0; i < items.Length; i++)
        {
            newItems[i] = items[i];
        }
        items = newItems;
    }

    public void PrintList()
    {
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Value is: " + items[i]);
        }
    }
}
class Node
{
    public int Value;
    public Node? Next;
    public Node? Prev;
    public Node(int value)
    {
        Value = value;
        Next = null;
        Prev = null;
    }
}

class CustomLinkedList {     
    private Node? head;
    private Node? tail;
    private int count;
    
    public CustomLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }
    
    public Node Add(int item)
    {
        Node newNode = new Node(item);
        
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
        count++;
        return newNode;
    }
    
    public bool Remove(Node node)
    {
        if (head == null)
        {
            return false;
        }
        
        Node? current = head;
        
        while (current != null && current != node)
        {
            current = current.Next;
        }
        
        if (current == null)
        {
            return false;
        }
        
        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            head = current.Next;
        }
        
        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
        else
        {
            tail = current.Prev;
        }
        
        if (count == 1)
        {
            head = null;
            tail = null;
        }
        
        count--;
        return true;
    }
    
    public int Count
    {
        get { return count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomList customList = new();
        customList.Add(1);
        customList.Add(2);
        customList.Add(3);
        customList.Remove(1);
        customList.PrintList();

        CustomLinkedList list = new CustomLinkedList();
        var firstNode = list.Add(1);
        var secondNode = list.Add(2);
        list.Add(3);
        var thirdNode = list.Add(4);
        list.Add(5);

        list.Remove(secondNode);
        list.Remove(thirdNode);

        while(firstNode != null)
        {
            Console.WriteLine("Node value is: " + firstNode.Value);
            firstNode = firstNode.Next;
        }
    }
}