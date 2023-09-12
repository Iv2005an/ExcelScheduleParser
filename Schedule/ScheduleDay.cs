using OfficeOpenXml;

namespace ExcelScheduleParser.Schedule;

public class ScheduleDay
{
    readonly public List<ScheduleLesson> lessons = new();
    public ScheduleDay(ExcelWorksheet excelWorksheet, int dayRow, int dayColumn)
    {
        for (int i = dayRow; i < dayRow + 14; i++)
        {
            lessons.Add(new ScheduleLesson(excelWorksheet, i, dayColumn));
        }
    }
}

