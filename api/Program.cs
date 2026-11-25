var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

app.UseHttpsRedirection();

var eventsApi = app.MapGroup("/api/calendar/events");

eventsApi.MapGet("/date", (DateOnly from, DateOnly to) =>
{
    return $"{from} to {to}";
});



app.Run();
