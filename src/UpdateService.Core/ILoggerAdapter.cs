using System;

namespace UpdateService.Core
{
    public interface ILoggerAdapter<T>
    {
        void LogInformation(string message, params object[] args);
        void LogError(Exception ex, string message, params object[] args);
    }
}