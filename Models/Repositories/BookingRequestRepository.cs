using Webshop.Data;

namespace Webshop.Models.Repositories
{
    public class BookingRequestRepository : IBookingRequestRepository
    {
        private readonly ApplicationContext _context;

        public BookingRequestRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task AddBookingRequest(BookingRequest request)
        {
            _context.BookingRequests.Add(request);
            await _context.SaveChangesAsync();
        }
    }
}
