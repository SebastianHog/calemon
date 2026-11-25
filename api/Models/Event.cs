namespace api.Models;

public class Event
{
    public int Id { get; set; }
    public int CalendarId { get; set; }
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public bool FullDayEvent { get; set; }
}
