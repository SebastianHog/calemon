using api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.UseHttpsRedirection();

var eventsApi = app.MapGroup("/api/calendar/events");

eventsApi.MapGet("/date", async (DateOnly from, DateOnly to, AppDbContext db) =>
{
    var start = from.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc);
    var end = to.AddDays(1).ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc);

    return await db.Events.Where(e => e.Start < end && e.End >= start).ToListAsync();
});

eventsApi.MapPost("/event", async (Event newEvent, AppDbContext db) =>
{
    db.Events.Add(newEvent);
    await db.SaveChangesAsync();
    return Results.Created($"/api/calendar/events/{newEvent.Id}", newEvent);
});



app.Run();
