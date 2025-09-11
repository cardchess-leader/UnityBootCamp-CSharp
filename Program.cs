class Program
{
    static void Main(string[] args)
    {
        int[,] map =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
        };
        Flip2DArray(map);
        for(int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Flip2DArray(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j <  a.GetLength(1); j++)
            {
                if (i > j)
                {
                    int temp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = temp;
                }
            }
        }
    }
}