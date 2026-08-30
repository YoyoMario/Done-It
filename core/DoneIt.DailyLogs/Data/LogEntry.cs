namespace DoneIt.DailyLogs.Data
{
    public class LogEntry
    {
        private Guid _guid = default;
        private DateTime _timestamp = default;
        private string _content = default;

        public Guid Guid => _guid;
        public DateTime Timestamp => _timestamp;
        public string Content => _content;

        public LogEntry(Guid guid, DateTime timestamp, string content)
        {
            _guid = guid;
            _timestamp = timestamp;
            _content = content;
        }
    }
}
