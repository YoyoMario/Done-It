using DoneIt.DailyLogs.Data;
using DoneIt.DailyLogs.Services;
using Microsoft.AspNetCore.Components;

namespace DoneIt.Web.Components.Daily_Logs.design
{
    public partial class LogGroupComponentPreview
    {
        [Inject]
        private IDailyLogGroupEntryService DailyLogGroupEntryService { get; set; } = default!;
        
        private LogGroupEntry _logGroupEntry = default!;

        protected override async Task OnInitializedAsync()
        {
            _logGroupEntry = await DailyLogGroupEntryService.GetAsync();
        }
    }
}
