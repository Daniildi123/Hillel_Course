using System;

public class CalculatorPlugin : IPlugin
{
    public void Execute()
    {
        int a = 5;
        int b = 3;
        int result = a + b;
        Console.WriteLine($"CalculatorPlugin: The result of {a} + {b} is {result}");
    }
}
