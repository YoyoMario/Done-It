using System.Drawing;

namespace DoneIt.DailyLogs.Data
{
    public class LogGroupEntry
    {
        private Guid _guid = default;
        private string _title = default!;
        private List<LogEntry> _logEntries = new List<LogEntry>();

        public Guid Guid => _guid;
        public string Title => _title;
        public List<LogEntry> LogEntries => _logEntries;

        public LogGroupEntry(Guid guid, string title, List<LogEntry> logEntries)
        {
            _guid = guid;
            _title = title;
            _logEntries = logEntries;
        }
    }
}
