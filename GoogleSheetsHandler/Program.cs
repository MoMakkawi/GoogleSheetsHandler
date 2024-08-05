using GoogleSheetsHandler;
using static GoogleSheetsEndpoints;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRefitClient<IGoogleSheetsApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://sheets.googleapis.com"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

MapGoogleSheetsEndpoints(app);

app.Run(); 
