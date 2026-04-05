using System;

class ForEach
{
    static void Main(string[] args)
    {
        string[] names = ["Arif", "Jepri", "Bima"];

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        int[] inv = [200, 450, 700, 175, 250];
        int sum = 0;
        int bin = 0;

        foreach (int items in inv)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }

        Console.WriteLine($"We have {sum} items in inventory");
    }
}