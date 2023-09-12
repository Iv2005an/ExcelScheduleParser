using OfficeOpenXml;
namespace ExcelScheduleParser.Schedule;

public class ScheduleLesson
{
    readonly public string name;
    readonly public string type;
    readonly public string teacher_name;
    readonly public string class_number;
    readonly public string link;

    public ScheduleLesson(ExcelWorksheet excelWorksheet, int lessonRow, int lessonColumn)
    {
        name = excelWorksheet.Cells[lessonRow, lessonColumn].Text;
        type = excelWorksheet.Cells[lessonRow, lessonColumn + 1].Text;
        teacher_name = excelWorksheet.Cells[lessonRow, lessonColumn + 2].Text;
        class_number = excelWorksheet.Cells[lessonRow, lessonColumn + 3].Text;
        link = excelWorksheet.Cells[lessonRow, lessonColumn + 4].Text;
    }
}

