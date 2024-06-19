using System;
using System.Collections.Generic;
using System.Linq;

namespace EnemyHomePath
{
    class Program
    {
        const int MAX = 201;
        const int INF = int.MaxValue;
        static int N;
        static int[,] MAP = new int[MAX, MAX];
        static (int, int) Home;
        static List<(int, int)> Enemy = new List<(int, int)>();
        static int Answer = INF;

        static void Main(string[] args)
        {
            Input();
            Settings();
            FindAnswer();
        }

        static void Input()
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var line = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    MAP[i + j, N - 1 - i + j] = int.Parse(line[j]);
                    if (MAP[i + j, N - 1 - i + j] == 1)
                    {
                        Enemy.Add((i + j, N - 1 - i + j));
                    }
                    else if (MAP[i + j, N - 1 - i + j] == 2)
                    {
                        Home = (i + j, N - 1 - i + j);
                    }
                }
            }
        }

        static void Settings()
        {
            if (!Enemy.Any())
            {
                Answer = 0;
                return;
            }

            Enemy.Sort();
            do
            {
                int nowY = Home.Item1;
                int nowX = Home.Item2;
                bool finish = true;
                int time = 0;
                foreach (var enemy in Enemy)
                {
                    int subY = Math.Abs(nowY - enemy.Item1);
                    int subX = Math.Abs(nowX - enemy.Item2);
                    if (subY % 2 == 0 && subX % 2 == 0)
                    {
                        time += subY + subX;
                        nowY = enemy.Item1;
                        nowX = enemy.Item2;
                    }
                    else
                    {
                        finish = false;
                        break;
                    }
                }
                if (finish)
                {
                    Answer = Math.Min(Answer, time / 2);
                }
            } while (NextPermutation(Enemy));
        }

        static void FindAnswer()
        {
            if (Answer == INF)
            {
                Console.WriteLine("Shorei");
            }
            else
            {
                Console.WriteLine("Undertaker");
                Console.WriteLine(Answer);
            }
        }

        static bool NextPermutation(List<(int, int)> list)
        {
            int i = list.Count - 1;
            while (i > 0 && list[i - 1].CompareTo(list[i]) >= 0)
                i--;
            if (i <= 0)
                return false;

            int j = list.Count - 1;
            while (list[j].CompareTo(list[i - 1]) <= 0)
                j--;

            var temp = list[i - 1];
            list[i - 1] = list[j];
            list[j] = temp;

            list.Reverse(i, list.Count - i);
            return true;
        }
    }
}
