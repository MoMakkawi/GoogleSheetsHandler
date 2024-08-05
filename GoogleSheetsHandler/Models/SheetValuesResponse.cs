namespace GoogleSheetsHandler.Models;

public record SheetValuesResponse(
    string Range,
    IList<IList<object>> Values);
