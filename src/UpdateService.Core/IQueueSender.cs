using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UpdateService.Core
{
    public interface IQueueSender
    {
        Task SendMessageToQueue(string message, string queueName);
    }
}
