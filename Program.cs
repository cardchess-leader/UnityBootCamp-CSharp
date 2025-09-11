class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        Swap(ref x, ref y);

        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}