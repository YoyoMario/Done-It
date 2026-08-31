using DoneIt.DailyLogs.Data;

namespace DoneIt.DailyLogs.Services
{
    public interface IDailyLogEntryService
    {
        public Task<DailyLogEntry> GetAsync(DateOnly date, CancellationToken cancellationToken = default);
    }
}
