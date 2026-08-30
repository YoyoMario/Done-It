namespace DoneIt.DailyLogs.Data
{
    public class DailyLogEntry
    {
        private Guid _guid = default;
        private Guid _ownerGuid = default;
        private DateOnly _date = default;
        private List<LogGroupEntry> _dailyLogGroups = new List<LogGroupEntry>();

        public Guid Guid => _guid;
        public Guid OwnerGuid => _ownerGuid;
        public DateOnly Date => _date;
        public List<LogGroupEntry> DailyLogGroups => _dailyLogGroups;

        public DailyLogEntry(Guid guid, Guid ownerGuid, DateOnly date, List<LogGroupEntry> dailyLogGroups)
        {
            _guid = guid;
            _ownerGuid = ownerGuid;
            _date = date;
            _dailyLogGroups = dailyLogGroups;
        }
    }
}
