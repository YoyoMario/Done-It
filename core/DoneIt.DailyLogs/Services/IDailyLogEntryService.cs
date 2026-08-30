using DoneIt.DailyLogs.Data;

namespace DoneIt.DailyLogs.Services
{
    public interface IDailyLogEntryService
    {
        public Task<DailyLogEntry> GetAsync(CancellationToken cancellationToken = default);
    }
}
