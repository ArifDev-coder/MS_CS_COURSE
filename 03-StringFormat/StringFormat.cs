using System;

class StringFormat
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\tHello\nWorld");
        Console.WriteLine("Hey, \"Jep\"");

        Console.WriteLine("\\home\\userlearningcsharp");

        Console.WriteLine(@"
\home\user\repos
    (here is your repo)
    ");

        // Kon'nichiwa World
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");


        string bang = "Arif";
        Console.WriteLine("Halo" + bang);
        Console.WriteLine($"Wow its amezing, right {bang}?");
    }
}