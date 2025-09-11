using System.Collections.Specialized;

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
        CountingStar("abczzz");
    }

    static void CountingStar(string str)
    {
        var arr = new int[26];
        foreach(var c  in str)
        {
            arr[c - 'a']++;
        }
        foreach(var i in arr)
        {
            Console.Write(i + " ");
        }
    }
}