

public class Program
{
    public static void Main(string[] args)
    {
        PluginManager pluginManager = new PluginManager();

        IPlugin calculatorPlugin = new CalculatorPlugin();
        IPlugin greetingPlugin = new GreetingPlugin();

        pluginManager.LoadPlugin(calculatorPlugin);
        pluginManager.LoadPlugin(greetingPlugin);

        pluginManager.ExecutePlugins();
        Console.ReadKey();


    }
}
