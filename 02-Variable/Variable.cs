using System;

class Program
{
    public static void Main(string[] args)
    {
        // Variable names can contain alphanumeric characters and the underscore character. Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
        // Variable names must begin with an alphabetical letter or an underscore, not a number.
        // Variable names are case-sensitive, meaning that string Value; and string value; are two different variables.
        // Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.


        string firstName = "Zainul";
        string lastName = "ArifDev";
        lastName = "Arif";
        // [string, int, decimal, bool]

        // string $thisErrorVar = "Error";

        Console.WriteLine($"My name is {firstName} {lastName}");

        // The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
        // You'll likely see the var keyword as you read other people's code; however, you should use the data type when possible.
        var Hobby = "Coding"; // The type data value can't be changed and must be initialized
        // Hobby = 14.5m; -> Wil be Error

        Console.WriteLine($"My Hobby Is {Hobby}");
    }
}