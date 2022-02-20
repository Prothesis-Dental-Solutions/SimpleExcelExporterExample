// See https://aka.ms/new-console-template for more information
using SimpleExcelExporter;
using SimpleExcelExporterExample;

// Instanciate the objects to export
var team = new Team
{
  Players =
{
  new Player
  {
    PlayerName = "Alexandre",
    Size = 1.93d,
    DateOfBirth = new DateTime(1974, 02, 01),
    IsActiveFlag = true,
    NumberOfVictory = 45,
    Salary = 2000.50m,
  },
  new Player
  {
    PlayerName = "Elina",
    Size = 1.72d,
    DateOfBirth = new DateTime(1990, 10, 13),
    IsActiveFlag = true,
    NumberOfVictory = 52,
    Salary = 2141.25m,
  }
},
};

// Create a temp directory
var n = DateTime.Now;
var tempDi = new DirectoryInfo($"ExampleOutput-{n.Year - 2000:00}-{n.Month:00}-{n.Day:00}-{n.Hour:00}{n.Minute:00}{n.Second:00}");
tempDi.Create();

// Export team to an excel file
using var memoryStream = new MemoryStream();
using var streamWriter = new StreamWriter(memoryStream);
SpreadsheetWriter spreadsheetWriter = new SpreadsheetWriter(streamWriter.BaseStream, team);
spreadsheetWriter.Write();
using FileStream file = new FileStream(Path.Combine(tempDi.FullName, "Team.xlsx"), FileMode.Create, FileAccess.Write);
memoryStream.WriteTo(file);
