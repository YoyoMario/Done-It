using System.Drawing;

namespace DoneIt.DailyLogs.Data
{
    internal class DailyLogGroup
    {
        private Guid _guid = default;
        private string _title = default!;
        private Color _color = Color.AliceBlue;

        private List<LogEntry> _logEntries = new List<LogEntry>();
    }
}
