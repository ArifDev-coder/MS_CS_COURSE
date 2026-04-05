using System;

class IFelse
{
    static void Main(string[] args)
    {
        Random dice = new();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            if (roll1 == roll2 && roll1 == roll3)
            {
                Console.WriteLine("You rolled triples! +6 bonus to total");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled dubles! +2 bonus to total!");
                total += 2;
            }
            Console.WriteLine($"Total: {total}");
        }

        if (total >= 20)
        {
            Console.WriteLine("You Win a new Car!");
        } 
        else if (total >= 15)
        {
            Console.WriteLine("You Win a new PC!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a new RTX 3090!");
        }
        else
        {
            Console.WriteLine("You win a cow shit!");
        }

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }
    }
}