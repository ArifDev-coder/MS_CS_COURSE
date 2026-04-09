using System;

// Variable name rules
// There are some variable naming rules that are enforced by the C# compiler.

// Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
// Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields. A link to further reading can be found in the module summary.
// Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
// Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

class ReadableCode
{
    static void Main()
    {
        // char userOption;
        // int gameScore;
        // float pariclesPerMillion;
        // bool processedCustomer;

        // When you want to leave a note about the intent of a passage of code. It can be helpful to include code comments that describe the purpose or the thought process when you're writing a particularly challenging set of coding instructions. Your future self will thank you.
        // When you want to temporarily remove code from your application to try a different approach, but you're not yet convinced your new idea will work. You can comment out the code, write the new code, and once you're convinced the new code will work the way you want it to, you can safely delete the old (commented code).
        // Adding a message like TODO to remind you to look at a given passage of code later. While you should use this judiciously, it's a useful approach. You may be working on another feature when you read a line of code that sparks a concern. Rather than ignoring the new concern, you can mark it for investigation later.

        string[] orderIDs = RandomOrderIDs(5);
        foreach (string orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }

        RandomDice();
    }


    /// <summary>
    //   The following code creates five random OrderIDs
    //   to test the fraud detection process.  OrderIDs 
    //   consist of a letter from A to E, and a three
    //   digit number. Ex. A123.
    /// </summary>
    public static string[] RandomOrderIDs(int val)
    {
        Random random = new();
        string[] orderIDs = new string[val];

        // Loop through each blank orderID
        for (int i = 0; i < orderIDs.Length; i++)
        {
            // Get a random value that equates to ASCII letters A through E
            int prefixValue = random.Next(65, 70);
            // Convert the random value int a char, then a string
            string prefix = Convert.ToChar(prefixValue).ToString();
            // Create a random number, pad with zeroes
            string suffix = random.Next(1, 1000).ToString("000");
            // Combine the prefix and suffix together, then assign to current OrderID
            orderIDs[i] = prefix + suffix;
        }

        return orderIDs;
    }

    public static void RandomDice()
    {
        // Whitespace for improve readability
        Random dice = new();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
            Console.WriteLine($"Total Score: ${total}");
        }
    }
}