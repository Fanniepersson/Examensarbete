namespace Webshop.Models.Repositories
{
    public interface IBookingRequestRepository
    {
         Task AddBookingRequest(BookingRequest request);
        Task<IEnumerable<BookingRequest>> GetAllRequests();
        Task<BookingRequest> GetRequestById(int id);
        Task DismissBookingRequest(int id);
        Task AcceptBookingRequest(BookingRequest request);
    }
}
