using System;
using System.Threading.Tasks;

namespace UpdateService.Core
{
    public class EntryPointService : IEntryPointService
    {
        private readonly ILoggerAdapter<EntryPointService> _logger;
        private readonly IQueueSender _queueSender;
        private readonly IQueueReceiver _queueReceiver;

        public EntryPointService(ILoggerAdapter<EntryPointService> logger, 
            IQueueReceiver queueReceiver, 
            IQueueSender queueSender)
        {
            _logger = logger;
            _queueReceiver = queueReceiver;
            _queueSender = queueSender;
        }

        public IQueueReceiver QueueReceiver { get; }

        public async Task ExecuteAsync()
        {
             _logger.LogInformation("{service} running at: {time}",nameof(EntryPointService), DateTimeOffset.Now);
            
            try
            {
                await _queueReceiver.GetMessageFromQueue("");

                // Do some work
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(EntryPointService)}.{nameof(ExecuteAsync)} threw an exception. ");
                // TODO: Decide if you want to re-throw which will crash the worker service
            }

        }
    }
}
