using DoneIt.DailyLogs.Data;
using Microsoft.AspNetCore.Components;

namespace DoneIt.Web.Components.DailyLogs
{
    public partial class DailyLogLayout
    {
        [Parameter]
        public bool TestDesign { get; set; } = default!;
        [Parameter]
        public DailyLogEntry DailyLogEntry { get; set; } = default!;
    }
}
