using System;

class Challenge
{
    public static void Main(string[] args)
    {
        int fahrenheit = 94;
        decimal ToCelsius = (fahrenheit - 32m) * 5m / 9m;

        Console.WriteLine($"The temperature is {ToCelsius.ToString("F1")} Celcius");
    }
}