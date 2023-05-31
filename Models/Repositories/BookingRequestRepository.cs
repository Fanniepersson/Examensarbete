using Microsoft.EntityFrameworkCore;
using Webshop.Data;
using Webshop.State;

namespace Webshop.Models.Repositories
{
    public class BookingRequestRepository : IBookingRequestRepository
    {
        private readonly ApplicationContext _context;
        private readonly ApplicationState _applicationState;
        public BookingRequestRepository(ApplicationContext context, ApplicationState applicationState)
        {
            _context = context;
            _applicationState = applicationState;
        }

        public async Task AcceptBookingRequest(BookingRequest request)
        {
            var acceptBooking = await _context.BookingRequests.FirstOrDefaultAsync(x => x.BookingId == request.BookingId);

            if (acceptBooking != null)
            {
                acceptBooking.Status = Status.Accepted;
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
            }
        }

        public async Task<IEnumerable<BookingRequest>> GetAllRequests()
        {
           return await _context.BookingRequests.Where(x => x.Status == Status.NotSet).ToListAsync();
        }

        public async Task<BookingRequest> GetRequestById(int id)
        {
            var selectedRequest =  await _context.BookingRequests.Include(x => x.EventType).FirstOrDefaultAsync(x => x.BookingId == id);

            //var selectedRequestEventType = _context.BookingRequests.Include(x => x.EventType);
            return selectedRequest;
        }
    }
}
