using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace DoneIt.Web.Components.DailyLogs;

public partial class DatePickerLayout
{
    private static readonly string[] Weekdays =
        ["M", "T", "W", "T", "F", "S", "S"];

    [Parameter]
    public DateOnly SelectedDate { get; set; }

    [Parameter]
    public EventCallback<DateOnly> SelectedDateChanged { get; set; }

    private DateOnly CurrentSelection { get; set; }
    private DateOnly VisibleMonth { get; set; }
    private DateOnly PreviousSelectedDate { get; set; }

    private string VisibleMonthLabel =>
        VisibleMonth.ToString("MMMM yyyy", CultureInfo.CurrentCulture);

    private IEnumerable<DateOnly?> CalendarDays
    {
        get
        {
            int leadingDays = ((int)VisibleMonth.DayOfWeek + 6) % 7;
            int daysInMonth = DateTime.DaysInMonth(VisibleMonth.Year, VisibleMonth.Month);

            for (int index = 0; index < leadingDays; index++)
            {
                yield return null;
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                yield return new DateOnly(VisibleMonth.Year, VisibleMonth.Month, day);
            }
        }
    }

    protected override void OnParametersSet()
    {
        if (SelectedDate == PreviousSelectedDate)
        {
            return;
        }

        PreviousSelectedDate = SelectedDate;
        CurrentSelection = SelectedDate;
        VisibleMonth = new DateOnly(SelectedDate.Year, SelectedDate.Month, 1);
    }

    private void ShowPreviousMonth() => VisibleMonth = VisibleMonth.AddMonths(-1);

    private void ShowNextMonth() => VisibleMonth = VisibleMonth.AddMonths(1);

    private async Task SelectDateAsync(DateOnly date)
    {
        CurrentSelection = date;
        await SelectedDateChanged.InvokeAsync(date);
    }

    private string GetDayClass(DateOnly date)
    {
        string cssClass = "date-picker-day";

        if (date == DateOnly.FromDateTime(DateTime.Today))
        {
            cssClass += " is-today";
        }

        if (date == CurrentSelection)
        {
            cssClass += " is-selected";
        }

        return cssClass;
    }
}
