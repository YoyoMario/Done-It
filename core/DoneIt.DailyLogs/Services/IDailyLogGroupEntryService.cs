using DoneIt.DailyLogs.Data;

namespace DoneIt.DailyLogs.Services
{
    public interface IDailyLogGroupEntryService
    {
        public Task<LogGroupEntry> GetAsync(CancellationToken cancellationToken = default);
    }
}
