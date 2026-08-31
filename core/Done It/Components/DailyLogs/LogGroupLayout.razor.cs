using DoneIt.DailyLogs.Data;
using Microsoft.AspNetCore.Components;

namespace DoneIt.Web.Components.DailyLogs
{
    public partial class LogGroupLayout
    {
        [Parameter]
        public bool TestDesign { get; set; } = default!;
        [Parameter]
        public LogGroupEntry LogGroupEntry { get; set; } = default!;
    }
}
