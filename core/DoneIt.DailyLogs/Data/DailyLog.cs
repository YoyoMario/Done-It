namespace DoneIt.DailyLogs.Data
{
    internal sealed class DailyLog
    {
        private Guid _guid = default;
        private Guid _ownerGuid = default;
        private DateOnly _date = default;
        private List<DailyLogGroup> _dailyLogGroups = new List<DailyLogGroup>();
    }
}
