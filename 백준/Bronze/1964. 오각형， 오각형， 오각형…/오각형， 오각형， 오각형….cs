using System;

class MainClass {
    public static void Main (string[] args) {
        int N = int.Parse(Console.ReadLine());
        long result = (3L * N * N + 5 * N + 2) / 2 % 45678;
        Console.WriteLine(result);
    }
}
