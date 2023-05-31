namespace Webshop.Models.Repositories
{
    public interface IBookingRequestRepository
    {
         Task AddBookingRequest(BookingRequest request);
        Task<IEnumerable<BookingRequest>> GetAllRequests();
        Task<BookingRequest> GetRequestById(int id);
        Task DismissBookingRequest(BookingRequest request);
        Task AcceptBookingRequest(BookingRequest request);
    }
}
