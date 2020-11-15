using System;
using System.Threading.Tasks;

namespace UpdateService.Core
{
    public interface IEntryPointService
    {
        Task ExecuteAsync();
    }
}