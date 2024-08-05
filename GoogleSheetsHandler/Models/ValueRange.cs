namespace GoogleSheetsHandler.Models;

public record ValueRange(
    string Range,
    IList<IList<object>> Values);
