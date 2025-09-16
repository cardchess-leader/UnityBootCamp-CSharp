class Program
{
    static void Main(string[] args)
    {
        int N, M;
        var inputs = Console.ReadLine()!.Split();
        N = int.Parse(inputs[0]);
        M = int.Parse(inputs[1]);
        bool [,] map = new bool[N, M];
        for (var i = 0; i < N; i++)
        {
            var s = Console.ReadLine()!;
            for (var j = 0; j < M; j++)
            {
                map[i, j] = s[j] == '1';
            }
        }

        bool [,] visited = new bool[N, M];
        int[,] dist = new int[N, M];
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((0, 0));
        visited[0, 0] = true;
        dist[0, 0] = 1;
        while(q.Count > 0)
        {
            var cur = q.Dequeue();
            (int, int)[] delta = { (1, 0), (0, 1), (-1, 0), (0, -1) };
            foreach(var (dx, dy) in delta)
            {
                var newPos = (cur.Item1 + dx, cur.Item2 + dy);
                if (newPos.Item1 < 0 || newPos.Item1 >= N || newPos.Item2 < 0 || newPos.Item2 >= M) continue;
                if (!map[newPos.Item1, newPos.Item2]) continue;
                if (visited[newPos.Item1, newPos.Item2]) continue;
                q.Enqueue(newPos);
                visited[newPos.Item1, newPos.Item2] = true;
                dist[newPos.Item1, newPos.Item2] = dist[cur.Item1, cur.Item2] + 1;
            }
        }

        Console.WriteLine(dist[N - 1, M - 1]);
    }
}