using Microsoft.EntityFrameworkCore;
using Webshop.Data;

namespace Webshop.Models.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationContext _context;

        public EventRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EventType>> GetAllEventTypes()
        {
            return await _context.EventTypes.OrderBy(x => x.Event).ToListAsync();
        }
    }
}
