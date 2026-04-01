using System;

class OperationNumber
{
    public static void Main(string[] args)
    {
        string abang = "Arif";
        int total = 1 + 1;

        Console.WriteLine(abang + " calculate " + total + 1);
        Console.WriteLine(abang + " calculate " + (total + 1));

        int sum = 7 + 5;
        int difference = 7 - 5;
        int product = 7 * 5;

        int first = 7;
        int second = 5;

        decimal quotient = (decimal)first / (decimal)second;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);

        // remainder of division
        Console.WriteLine($"Modulus of 7 / 5 is {first % second}");

        int value = 0;
        Console.WriteLine(value);
        value = value + 5;
        Console.WriteLine(value);
        value += 5;
        Console.WriteLine(value);
        value++;
        Console.WriteLine(value);
        value--;
        Console.WriteLine(value);

        value *= 0;
        Console.WriteLine("First: " + value);
        Console.WriteLine($"Second: {value++}");
        Console.WriteLine("Third: " + value);
        Console.WriteLine("Fourth: " + (++value));

        Console.WriteLine("Winslop " + 1 + 1);

        Console.WriteLine(5 / 10);
    }
}