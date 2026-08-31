using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace DoneIt.Web.Components.DailyLogs;

public partial class DailyLogDate
{
    [Parameter]
    public DateOnly SelectedDate { get; set; }

    private string FormattedDate =>
        SelectedDate.ToString("dddd, MMMM d, yyyy", CultureInfo.CurrentCulture);
}
