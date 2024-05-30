using System;
using System.Collections.Generic;

public static class Logger
{
    private static List<LogEntry> logs = new List<LogEntry>();

    public static void AddLog(string message)
    {
        logs.Add(new LogEntry(message));
    }

    public static List<LogEntry> GetLogs()
    {
        return new List<LogEntry>(logs);
    }
}
