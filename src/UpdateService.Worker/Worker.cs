using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UpdateService.Core;

namespace UpdateService.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILoggerAdapter<Worker> _logger;
        private readonly IEntryPointService _entryPointService;

        public Worker(ILoggerAdapter<Worker> logger, IEntryPointService entryPointService)
        {
            _logger = logger;
            _entryPointService = entryPointService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("UpdateService.Worker service starting at: {time}", DateTimeOffset.Now);
            while (!stoppingToken.IsCancellationRequested)
            {
                await _entryPointService.ExecuteAsync();
                await Task.Delay(1000, stoppingToken); // TODO: Move delay to appSettings
            }
            _logger.LogInformation("UpdateService.Worker service stopping at: {time}", DateTimeOffset.Now);
        }
    }
}
