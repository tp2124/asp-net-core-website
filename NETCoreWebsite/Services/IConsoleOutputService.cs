namespace NETCoreWebsite.Services
{
    using NETCoreWebsite.Models;

    public interface IConsoleOutputService
    {
        void HelloFormat(RepeatMessageModel message);
    }
}
