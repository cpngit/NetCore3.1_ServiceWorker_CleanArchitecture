using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UpdateService.Core;

namespace UpdateService.Infrastructure.Messaging
{
    public class InMemoryQueueSender : IQueueSender
    {
        public async Task SendMessageToQueue(string message, string queueName)
        {
            await Task.CompletedTask; 
        }
    }
}
