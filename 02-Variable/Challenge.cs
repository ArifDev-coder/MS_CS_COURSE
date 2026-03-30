using System;

class Challenge
{
    public static void Main(string[] args)
    {
        // Challenge: Display literal and variable values
        // Store the following values in variables:

        // Bob
        // 3
        // 34.4
        // These variables should be given names that reflect their purpose.

        // Make sure you select the correct data type for each of the variables based on the type of data it will hold.

        // Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.

        // Write code in the C# Code Editor to display the following message:

        // Output
        // Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
        // No matter how you do it, your code should produce the specified output.

        string name = "Bob";
        int numberOfMessages = 3;
        decimal temperature = 34.40M;

        Console.WriteLine($"Hello, {name}! You have {numberOfMessages} messages in your inbox. The temperature is {temperature} celsius");

    }
}