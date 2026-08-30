using DoneIt.DailyLogs.Data;
using DoneIt.DailyLogs.Services;

namespace DoneIt.DailyLogs.Mock.Services
{
    public class MockLogGroupEntryService : IDailyLogGroupEntryService
    {
        public Task<LogGroupEntry> GetAsync(CancellationToken cancellationToken = default)
        {
            LogGroupEntry logGroupEntry = new LogGroupEntry(
                Guid.NewGuid(),
                "Mock Log Group Entry",
                new List<LogEntry>
                {
                    new LogEntry(Guid.NewGuid(), new DateTime(2026, 8, 30, 9, 15, 0), "Mock Log Entry 1"),
                    new LogEntry(Guid.NewGuid(), new DateTime(2026, 8, 30, 12, 55, 0), "Mock Log Entry 2"),
                    new LogEntry(Guid.NewGuid(), new DateTime(2026, 8, 30, 15, 35, 0), "Mock Log Entry 3"),
                }
            );
            return Task.FromResult(logGroupEntry);
        }
    }
}
