using Microsoft.Extensions.Logging;
using System;
using UpdateService.Core;

namespace UpdateService.Infrastructure
{
    public class LoggerAdapter<T> : ILoggerAdapter<T>
    {
        private readonly ILogger<T> _logger;
    
        public LoggerAdapter(ILogger<T> logger)
        {
            _logger = logger;
        }
    
        public void LogError(Exception ex, string message, params object[] args)
        {
            _logger.LogError(ex, message, args);
        }
    
        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }
    }
}