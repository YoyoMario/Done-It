using DoneIt.DailyLogs.Data;
using DoneIt.DailyLogs.Services;

namespace DoneIt.DailyLogs.Mock.Services
{
    public class MockDailyLogEntryService : IDailyLogEntryService
    {
        public Task<DailyLogEntry> GetAsync(DateOnly date, CancellationToken cancellationToken = default)
        {
            DailyLogEntry dailyLog = new DailyLogEntry(
                Guid.NewGuid(),
                Guid.Empty,
                date,
                new List<LogGroupEntry>()
                {
                    new LogGroupEntry(
                        Guid.NewGuid(),
                        "Project X",
                        new List<LogEntry>()
                        {
                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(9, 30)),
                                "Reviewed the project requirements and created a task list."),
                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(10, 15)),
                                "Implemented the initial version of the user authentication module. #project-x"),
                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(11, 0)),
                                "Tested the authentication module and fixed a bug related to token expiration.")
                        }
                    ),
                    new LogGroupEntry(
                        Guid.NewGuid(),
                        "Personal",
                        new List<LogEntry>()
                        {
                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(12, 45)),
                                "Took a walk and planned the rest of the week."),

                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(13, 20)),
                                "Repotted the balcony basil. #home")
                        }
                    ),
                    new LogGroupEntry(
                        Guid.NewGuid(),
                        "Learning",
                        new List<LogEntry>()
                        {
                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(16, 20)),
                                "Studied Razor component composition. #blazor"),

                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(17, 5)),
                                "Read about CSS container queries.")
                        }
                    ),
                    new LogGroupEntry(
                        Guid.NewGuid(),
                        "Ideas",
                        new List<LogEntry>()
                        {
                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(18, 10)),
                                "Generate a weekly reflection from completed logs."),

                            new LogEntry(
                                Guid.NewGuid(),
                                date.ToDateTime(new TimeOnly(20, 45)),
                                "Explore a focused view for the current group.")
                        }
                    )
                }
            );

            return Task.FromResult(dailyLog);
        }
    }
}
