using api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

app.UseHttpsRedirection();

var eventsApi = app.MapGroup("/api/calendar/events");

eventsApi.MapGet("/date", (DateOnly from, DateOnly to) =>
{
    return $"{from} to {to}";
});

eventsApi.MapPost("/event", (Event newEvent) =>
{
    return newEvent;
});



app.Run();
