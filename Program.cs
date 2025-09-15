class CustomList<T>
{
    private T[] items;
    private int count;
    public CustomList()
    {
        items = new T[1];
        count = 0;
    }
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count++] = item;
    }
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[--count] = default(T);
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            items[index] = value;
        }
    }
    public int Count => count;
}
class Node
{
    public int Data;
    public Node? Next;
    public Node? Prev;
}

class MyLinkedList
{
    public Node? Head = null;
    public Node? Tail = null;
    public int count;

    public Node AddLast(int data)
    {
        Node newNode = new Node();

        // TODO : 구현
        newNode.Data = data;
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
        count++;
        return newNode;
    }

    public void Remove(Node node)
    {
        // TODO : 구현
        if (Head == null) return;

        // case 1: Head == node
        if (Head == node)
        {
            Head = node.Next;
        }
        if (Tail == node)
        {
            Tail = node.Prev;
        }
        if (node.Next != null)
        {
            node.Next.Prev = node.Prev;
        }
        if (node.Prev != null)
        {
            node.Prev.Next = node.Next;
        }
        count--;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        MyLinkedList list = new();
        var node1 = list.AddLast(1);
        list.AddLast(2);
        var node2 = list.AddLast(3);
        list.AddLast(4);
        var node3 = list.AddLast(5);
        list.Remove(node3);
        list.Remove(node1);
        list.Remove(node2);
        node1 = list.Head;
        while (node1 != null)
        {
            Console.WriteLine($"node data is: {node1.Data}");
            node1 = node1.Next;
        }
    }
}