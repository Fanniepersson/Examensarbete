using Microsoft.EntityFrameworkCore;
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

        public async Task AcceptBookingRequest(BookingRequest request)
        {
            var acceptBooking = await _context.BookingRequests.FirstOrDefaultAsync(x => x.BookingId == request.BookingId);

            if (acceptBooking != null)
            {
                acceptBooking.Status = Status.Accepted;
                await _context.SaveChangesAsync();
            }

        }

        public async Task AddBookingRequest(BookingRequest request)
        {
            _context.BookingRequests.Add(request);

            await _context.SaveChangesAsync();
        }

        public async Task DismissBookingRequest(BookingRequest request)
        {
            var dismissBooking = await _context.BookingRequests.FirstOrDefaultAsync(x => x.BookingId == request.BookingId);

            if (dismissBooking != null)
            {
                dismissBooking.Status = Status.Dismissed;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<BookingRequest>> GetAllRequests()
        {
           return await _context.BookingRequests.ToListAsync();
        }

        public async Task<BookingRequest> GetRequestById(int id)
        {
            var selectedRequest =  await _context.BookingRequests.Include(x => x.EventType).FirstOrDefaultAsync(x => x.BookingId == id);

            //var selectedRequestEventType = _context.BookingRequests.Include(x => x.EventType);
            return selectedRequest;
        }
    }
}
