using MSFD_EventEaseApp.Models;

namespace MSFD_EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<Event> _events;

        public EventService()
        {
            _events = GenerateSampleEvents();
        }

        public Task<List<Event>> GetAllEventsAsync()
        {
            return Task.FromResult(_events);
        }

        public Task<Event?> GetEventByIdAsync(int id)
        {
            var eventItem = _events.FirstOrDefault(e => e.EventId == id);
            return Task.FromResult(eventItem);
        }

        public Task<List<Event>> GetEventsByCategoryAsync(string category)
        {
            var filteredEvents = string.IsNullOrEmpty(category) 
                ? _events 
                : _events.Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            return Task.FromResult(filteredEvents);
        }

        private List<Event> GenerateSampleEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    EventId = 1,
                    Name = "Annual Tech Conference 2025",
                    Date = new DateTime(2025, 11, 15, 9, 0, 0),
                    Location = "Microsoft Conference Center, Redmond, WA",
                    Description = "Join industry leaders for insights into the latest technology trends, innovations, and future developments in software engineering and AI.",
                    Category = "Technology",
                    Price = 299.99m,
                    AvailableSeats = 500,
                    ImageUrl = "/images/tech-conference.jpg",
                    Organizer = "TechEvents Inc."
                },
                new Event
                {
                    EventId = 2,
                    Name = "Digital Marketing Summit",
                    Date = new DateTime(2025, 12, 5, 10, 0, 0),
                    Location = "Convention Center, Austin, TX",
                    Description = "Explore the latest strategies in digital marketing, social media engagement, and customer acquisition techniques.",
                    Category = "Marketing",
                    Price = 199.99m,
                    AvailableSeats = 300,
                    ImageUrl = "/images/marketing-summit.jpg",
                    Organizer = "Marketing Pro Events"
                },
                new Event
                {
                    EventId = 3,
                    Name = "Leadership Workshop",
                    Date = new DateTime(2025, 11, 22, 14, 0, 0),
                    Location = "Business Center, Chicago, IL",
                    Description = "Interactive workshop focusing on modern leadership skills, team management, and organizational effectiveness.",
                    Category = "Leadership",
                    Price = 149.99m,
                    AvailableSeats = 100,
                    ImageUrl = "/images/leadership-workshop.jpg",
                    Organizer = "Leadership Academy"
                },
                new Event
                {
                    EventId = 4,
                    Name = "Corporate Networking Gala",
                    Date = new DateTime(2025, 12, 10, 18, 30, 0),
                    Location = "Grand Ballroom, Chicago, IL",
                    Description = "An elegant evening of professional networking with industry executives, entrepreneurs, and thought leaders.",
                    Category = "Networking",
                    Price = 125.00m,
                    AvailableSeats = 250,
                    ImageUrl = "/images/networking-gala.jpg",
                    Organizer = "Business Connect"
                },
                new Event
                {
                    EventId = 5,
                    Name = "Innovation in Healthcare Symposium",
                    Date = new DateTime(2025, 11, 28, 8, 30, 0),
                    Location = "Medical Center Auditorium, Boston, MA",
                    Description = "Discover breakthrough innovations in healthcare technology, telemedicine, and patient care solutions.",
                    Category = "Healthcare",
                    Price = 275.00m,
                    AvailableSeats = 400,
                    ImageUrl = "/images/healthcare-symposium.jpg",
                    Organizer = "HealthTech Events"
                },
                new Event
                {
                    EventId = 6,
                    Name = "Startup Pitch Competition",
                    Date = new DateTime(2025, 12, 15, 13, 0, 0),
                    Location = "Innovation Hub, San Francisco, CA",
                    Description = "Watch emerging startups pitch their innovative ideas to a panel of venture capitalists and industry experts.",
                    Category = "Entrepreneurship",
                    Price = 75.00m,
                    AvailableSeats = 200,
                    ImageUrl = "/images/startup-pitch.jpg",
                    Organizer = "Startup Valley"
                }
            };
        }
    }
}