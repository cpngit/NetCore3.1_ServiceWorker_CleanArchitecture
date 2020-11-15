using Moq;
using System;
using System.Threading.Tasks;
using UpdateService.Core;
using Xunit;

namespace UpdateServices.UnitTests.Core
{
    
    public class EntryPointServiceExecuteAsync
    {
        [Fact]
        public async Task LogsExceptionsEncountered()
        {
            var mockLogger = new Mock<ILoggerAdapter<EntryPointService>>();
            var entryPointService = new EntryPointService(mockLogger.Object, null, null);

            await entryPointService.ExecuteAsync();

            mockLogger.Verify(l => l.LogError(It.IsAny<NullReferenceException>(), It.IsAny<string>()), Times.Once);
        }
    }
}
