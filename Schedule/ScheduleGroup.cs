using OfficeOpenXml;

namespace ExcelScheduleParser.Schedule;

public class ScheduleGroup
{
    readonly public string name;
    readonly public List<ScheduleDay> scheduleDays = new();

    public ScheduleGroup(ExcelWorksheet excelWorksheet, int groupRow, int groupColumn)
    {
        name = excelWorksheet.Cells[groupRow, groupColumn].Text;
        for (int i = groupRow + 2; i < groupRow + 86; i += 15)
        {
            scheduleDays.Add(new ScheduleDay(excelWorksheet, i, groupColumn));
        }
    }
}

