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

        public Task AcceptBookingRequest(BookingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task AddBookingRequest(BookingRequest request)
        {
            _context.BookingRequests.Add(request);

            await _context.SaveChangesAsync();
        }

        public Task DismissBookingRequest(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookingRequest>> GetAllRequests()
        {
           return await _context.BookingRequests.ToListAsync();
        }

        public async Task<BookingRequest> GetRequestById(int id)
        {
            var selectedRequest =  await _context.BookingRequests.FirstOrDefaultAsync(x => x.BookingId == id);
            return selectedRequest;
        }
    }
}
