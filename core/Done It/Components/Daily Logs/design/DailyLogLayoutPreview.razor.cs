using DoneIt.DailyLogs.Data;
using Microsoft.AspNetCore.Components;

namespace DoneIt.Web.Components.Daily_Logs.design
{
    public partial class DailyLogLayoutPreview
    {
        [Parameter]
        public bool TestDesign { get; set; } = default!;
        [Parameter]
        public DailyLogEntry DailyLogEntry { get; set; } = default!;
    }
}
