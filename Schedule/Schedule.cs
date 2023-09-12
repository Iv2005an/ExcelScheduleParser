using System.Net;
using OfficeOpenXml;

namespace Schedule_for_educational_institutions.Models.Schedule;

public class Schedule
{
    readonly public List<ScheduleGroup> groups = new();

    public Schedule(string excel_file_name)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using ExcelPackage excel_file = new(excel_file_name);
        ExcelWorksheet excelWorksheet = excel_file.Workbook.Worksheets[0];

        int row = 2;
        int column = 6;
        bool big_space = true;
        while (true)
        {
            ExcelRange cell = excelWorksheet.Cells[row, column];
            if (cell.Style.Font.Size != 18)
            {
                break;
            }
            if (cell.Text != "")
            {
                groups.Add(new ScheduleGroup(excelWorksheet, row, column));
            }
            column += big_space ? 5 : 10;
            big_space = !big_space;
        }
    }
}

