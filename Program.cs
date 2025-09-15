class Program
{
    static void DFS(int x, int y, bool[,] grid)
    {
        grid[x, y] = false;
        int[] deltaX = { -1, 0, 1, 0 };
        int[] deltaY = { 0, -1, 0, 1 };
        for (int i = 0; i < deltaX.Length; i++)
        {
            int newX = x + deltaX[i];
            int newY = y + deltaY[i];
            if (newX < 0 || newX >= grid.GetLength(0) || newY < 0 || newY >= grid.GetLength(1)) continue;
            if (!grid[newX, newY]) continue;
            DFS(newX, newY, grid);
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            var list = Console.ReadLine()!.Split();
            int width = int.Parse(list[0]), height = int.Parse(list[1]), inputCount = int.Parse(list[2]);
            var grid = new bool[width, height];
            for (int j = 0; j < inputCount; j++)
            {
                list = Console.ReadLine()!.Split();
                int x = int.Parse(list[0]), y = int.Parse(list[1]);
                grid[x, y] = true;
            }
            int count = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (grid[x, y])
                    {
                        count++;
                        DFS(x, y, grid);
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}