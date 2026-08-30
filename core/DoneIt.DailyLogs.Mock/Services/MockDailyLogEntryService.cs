using DoneIt.DailyLogs.Data;
using DoneIt.DailyLogs.Services;

namespace DoneIt.DailyLogs.Mock.Services
{
    public class MockDailyLogEntryService : IDailyLogEntryService
    {
        public Task<DailyLogEntry> GetAsync(CancellationToken cancellationToken = default)
        {

        }
    }
}
