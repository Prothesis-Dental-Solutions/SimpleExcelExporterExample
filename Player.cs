namespace SimpleExcelExporterExample
{
  using SimpleExcelExporter.Annotations;
  using SimpleExcelExporter.Definitions;

  public class Player
  {
    [CellDefinition(CellDataType.Date)]
    [Header(typeof(TeamRes), "DateOfBirthColumnName")]
    [Index(2)]
    public DateTime? DateOfBirth { get; set; }

    [CellDefinition(CellDataType.String)]
    [Header(typeof(TeamRes), "PlayerNameColumnName")]
    [Index(1)]
    public string? PlayerName { get; set; }

    [CellDefinition(CellDataType.Number)]
    [Header(typeof(TeamRes), "NumberOfVictoryColumnName")]
    [Index(3)]
    public int? NumberOfVictory { get; set; }

    [CellDefinition(CellDataType.Boolean)]
    [Header(typeof(TeamRes), "IsActiveFlagColumnName")]
    [Index(4)]
    public bool? IsActiveFlag { get; set; }

    [CellDefinition(CellDataType.Boolean)]
    [Header(typeof(TeamRes), "SizeColumnName")]
    [Index(5)]
    public double? Size { get; set; }

    [CellDefinition(CellDataType.Number)]
    [Header(typeof(TeamRes), "SalaryColumnName")]
    [Index(5)]
    public decimal? Salary { get; set; }
  }
}
