using GoogleSheetsHandler.Models;
using GoogleSheetsHandler.RefitAPIs;

namespace GoogleSheetsHandler.Endpoints;

public static class GoogleSheetsEndpoints
{
    public static void MapGoogleSheetsEndpoints(WebApplication app)
    {
        var apiKey = "your-google-api-key"; // Store securely in config or environment

        app.MapGet("/sheets/{spreadsheetId}/{range}", async (string spreadsheetId, string range, IGoogleSheetsApi sheetsApi) =>
        {
            var response = await sheetsApi.GetSheetValuesAsync(spreadsheetId, range, apiKey);
            return Results.Ok(response);
        });
        app.MapPost("/sheets/{spreadsheetId}/{range}/append", async (string spreadsheetId, string range, IGoogleSheetsApi sheetsApi, ValueRange body) =>
        {
            var response = await sheetsApi.AppendSheetValuesAsync(spreadsheetId, range, body, apiKey);
            return Results.Ok(response);
        });

        app.MapPut("/sheets/{spreadsheetId}/{range}/update", async (string spreadsheetId, string range, IGoogleSheetsApi sheetsApi, ValueRange body) =>
        {
            var response = await sheetsApi.UpdateSheetValuesAsync(spreadsheetId, range, body, apiKey);
            return Results.Ok(response);
        });

        app.MapDelete("/sheets/{spreadsheetId}/{range}/clear", async (string spreadsheetId, string range, IGoogleSheetsApi sheetsApi) =>
        {
            var response = await sheetsApi.ClearSheetValuesAsync(spreadsheetId, range, apiKey);
            return Results.Ok(response);
        });
    }
}