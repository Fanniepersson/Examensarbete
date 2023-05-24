namespace Webshop.Models.Repositories
{
    public interface IBookingRequestRepository
    {
        public Task AddBookingRequest(BookingRequest request);
    }
}
