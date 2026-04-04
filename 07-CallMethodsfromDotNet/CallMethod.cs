using System;

class CallMethod
{
    public static void Main(string[] args)
    {
        Random dice = new();

        while (true)
        {
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            if (roll == 6)
            {
                break;
            }
        }

        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"First roll: {roll2}");
        Console.WriteLine($"First roll: {roll3}");

        int firstVal = 500;
        int secondVal = 600;
        int largerValue = Math.Max(firstVal, secondVal);

        Console.WriteLine(largerValue);
    }
}