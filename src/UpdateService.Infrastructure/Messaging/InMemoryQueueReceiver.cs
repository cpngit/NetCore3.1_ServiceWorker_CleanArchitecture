using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UpdateService.Core;

namespace UpdateService.Infrastructure.Messaging
{
    public class InMemoryQueueReceiver : IQueueReceiver
    {
        public async Task<string> GetMessageFromQueue(string queueName)
        {
            return await Task.FromResult(string.Empty);
        }
    }
}
