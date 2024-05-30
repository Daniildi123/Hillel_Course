using System;

public class LogEntry
{
    public DateTime Timestamp { get; }
    public string Message { get; }

    public LogEntry(string message)
    {
        Timestamp = DateTime.Now;
        Message = message;
    }

    public override string ToString()
    {
        return $"{Timestamp}: {Message}";
    }
}
