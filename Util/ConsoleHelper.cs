namespace AlgorithmPractice.Util;

public static class ConsoleHelper
{
    public static void WriteTitle(string message)
    {
        WriteLine(message, ConsoleColor.White);
    }

    public static void WriteInput(string message, string? messageTwo = null)
    {
        if (!string.IsNullOrEmpty(messageTwo))
        {
            var messageToWrite = string.Join(" , ", message, messageTwo) + " ";
            Write(messageToWrite, ConsoleColor.DarkBlue);
        }
        else
        {
            Write(message, ConsoleColor.DarkBlue);
        }
    }

    public static void WriteOutput(string message)
    {
        Write(message + ".", ConsoleColor.DarkGreen);
        Console.WriteLine();
    }

    #region Helpers

    private static void Write(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }

    private static void WriteLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    #endregion
}