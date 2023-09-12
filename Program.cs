using ExcelScheduleParser.Schedule;
string excel_file_path = "/Users/ivan/Documents/RASPISANIE-01.09.2023-1-p.g.xlsx";
Schedule schedule = new(excel_file_path);

Console.WriteLine(schedule.groups[62].scheduleDays[3].lessons[3].name);
Console.ReadKey();