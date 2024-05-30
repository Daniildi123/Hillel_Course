using System;

public class GreetingPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("GreetingPlugin: Hello, welcome to the plugin system!");
    }
}
