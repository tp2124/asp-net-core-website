
namespace NETCoreWebsite.Services.Implementations
{
    using System;
    using NETCoreWebsite.Models;

    public class ConsoleOutputService : IConsoleOutputService
    {
        public void HelloFormat(RepeatMessageModel message)
        {
            Console.WriteLine($"Formatted message: {message}.");
        }
    }
}
