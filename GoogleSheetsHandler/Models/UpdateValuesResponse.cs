namespace GoogleSheetsHandler.Models;

public record UpdateValuesResponse(
    string SpreadsheetId,
    string UpdatedRange,
    int UpdatedRows,
    int UpdatedColumns,
    int UpdatedCells);
