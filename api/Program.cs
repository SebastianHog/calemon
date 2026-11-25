var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

app.UseHttpsRedirection();

var eventsApi = app.MapGroup("/api/calendar/events");

eventsApi.MapGet("/year", () => "Year");
eventsApi.MapGet("/month", () => "Month");
eventsApi.MapGet("/week", () => "Week");
eventsApi.MapGet("/day", () => "Day");



app.Run();
