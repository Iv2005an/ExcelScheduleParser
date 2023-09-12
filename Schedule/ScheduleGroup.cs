using System.Text.RegularExpressions;
using OfficeOpenXml;

namespace Schedule_for_educational_institutions.Models.Schedule;

public partial class ScheduleGroup
{
    readonly public string name;
    readonly public List<ScheduleDay> scheduleDays = new();

    public ScheduleGroup(ExcelWorksheet excelWorksheet, int groupRow, int groupColumn)
    {
        name = excelWorksheet.Cells[groupRow, groupColumn].Text;
        name = excessSpaces().Replace(name, "");
        name = shortGroupName().Replace(name, "");
        for (int i = groupRow + 2; i < groupRow + 86; i += 15)
        {
            scheduleDays.Add(new ScheduleDay(excelWorksheet, i, groupColumn));
        }
    }
    public override string ToString()
    {
        return name;
    }

    [GeneratedRegex("\\s+")]
    private static partial Regex excessSpaces();
    [GeneratedRegex("\\(.*")]
    private static partial Regex shortGroupName();
}

