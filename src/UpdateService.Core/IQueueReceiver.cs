using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UpdateService.Core
{
    public interface IQueueReceiver
    {
        Task<string> GetMessageFromQueue(string queueName);
    }
}
