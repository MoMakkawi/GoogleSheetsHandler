using GoogleSheetsHandler.Models;
using Refit;

namespace GoogleSheetsHandler.RefitAPIs;

public interface IGoogleSheetsApi
{
    [Get("/v4/spreadsheets/{spreadsheetId}/values/{range}")]
    Task<SheetValuesResponse> GetSheetValuesAsync(string spreadsheetId, string range, [Query] string key);

    [Post("/v4/spreadsheets/{spreadsheetId}/values/{range}:append?valueInputOption=USER_ENTERED")]
    Task<AppendValuesResponse> AppendSheetValuesAsync(string spreadsheetId, string range, [Body] ValueRange body, [Query] string key);

    [Put("/v4/spreadsheets/{spreadsheetId}/values/{range}?valueInputOption=USER_ENTERED")]
    Task<UpdateValuesResponse> UpdateSheetValuesAsync(string spreadsheetId, string range, [Body] ValueRange body, [Query] string key);

    [Post("/v4/spreadsheets/{spreadsheetId}/values/{range}:clear")]
    Task<ClearValuesResponse> ClearSheetValuesAsync(string spreadsheetId, string range, [Query] string key);
}
