namespace Webshop.Models.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<EventType>> GetAllEventTypes();
    }
}
