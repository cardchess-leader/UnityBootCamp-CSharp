using System.Collections.Specialized;

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
        AddOneToAdjacentCells(map, 1, 1);
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void AddOneToAdjacentCells(int[,] map, int y, int x)
    {
        int[] dX = { 1, 0, -1, 0 };
        int[] dY = { 0, 1, 0, -1 };
        for (int i = 0;i < dX.Length; i++)
        {
            int newX = dX[i] + x;
            int newY = dY[i] + y;
            if (newX >= 0 && newX < map.GetLength(1) && newY >= 0 && newY < map.GetLength(0))
            {
                map[newY, newX]++;
            }
        }
    }
}