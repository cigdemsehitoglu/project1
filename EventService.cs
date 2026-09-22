namespace EventEase.Services
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int AttendeeCount { get; set; }
        public bool IsFull => AttendeeCount >= Capacity;
    }

    public class EventService
    {
        private List<EventModel> _events = new()
        {
            new EventModel
            {
                Id = 1,
                Title = "Blazor Workshop",
                Description = "Learn how to build modern web apps with Blazor and Copilot.",
                Date = DateTime.Now.AddDays(7),
                Location = "Online",
                Capacity = 50,
                AttendeeCount = 12
            },
            new EventModel
            {
                Id = 2,
                Title = "Community Meetup",
                Description = "Network with other developers and share knowledge.",
                Date = DateTime.Now.AddDays(14),
                Location = "Istanbul Tech Hub",
                Capacity = 30,
                AttendeeCount = 28
            },
            new EventModel
            {
                Id = 3,
                Title = "Hackathon 2026",
                Description = "24-hour coding challenge with prizes.",
                Date = DateTime.Now.AddDays(30),
                Location = "Ankara Innovation Center",
                Capacity = 100,
                AttendeeCount = 45
            }
        };

        public List<EventModel> GetAllEvents() => _events;

        public EventModel? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

        public bool RegisterAttendee(int eventId)
        {
            var ev = GetEventById(eventId);
            if (ev == null || ev.IsFull) return false;
            ev.AttendeeCount++;
            return true;
        }
    }
}
