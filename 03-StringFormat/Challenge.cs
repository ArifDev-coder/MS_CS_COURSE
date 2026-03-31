using System;

class Challenge
{
    public static void Main(string[] args)
    {
        // The projectName variable will be used twice in the desired output.

        // The russianMessage variable contains the message "View Russian output" in Russian. You must use this variable in your code that prints the message.

        // You may not change these two lines of code, but you can add code above and below each line. You must use these two lines of code to form the desired output.

        // You may only use either the Console.WriteLine() or the Console.Write() method twice.
        // In other words, to complete this challenge, you can only create two instructions that actually print output to the console. If you need to print additional new lines or add any formatting, you must use what you've learned in this module to accomplish it.

        // Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.

        string projectName = "ACME";

        string englishLocation = $@"c:\\Exercise\\{projectName}\\data.txt";
        Console.WriteLine($"View English output:\n\t{englishLocation}\n");

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        string russianLocation = $@"c:\\Exercise\\{projectName}\\ru-RU\\data.txt";
        Console.WriteLine($"{russianMessage}:\n\t{russianLocation}");
    }
}