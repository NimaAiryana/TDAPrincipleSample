﻿internal class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}
