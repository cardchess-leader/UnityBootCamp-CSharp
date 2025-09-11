class Program
{
    static void Main(string[] args)
    {
        int[] a = { 15, 3, 9, 27, -5, 8, 99 };
        int max = int.MinValue, min = int.MaxValue;

        foreach(var num in a)
        {
            if(num > max) max = num;
            if(num < min) min = num;
        }

        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}