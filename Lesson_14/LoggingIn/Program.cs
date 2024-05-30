using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        Logger.AddLog("System started.");
        Logger.AddLog("User logged in.");
        Logger.AddLog("Error: Unable to connect to database.");

        
        var logs = Logger.GetLogs();
        foreach (var log in logs)
        {
            Console.WriteLine(log);
            Console.ReadKey();  
        }
    }
}
