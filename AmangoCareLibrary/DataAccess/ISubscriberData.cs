namespace AmangoCareLibrary.DataAccess
{
    public interface ISubscriberData
    {
        Task CreateSubscriber(SubscriberModel subscriber);
        Task<List<SubscriberModel>> GetAllSubscribers();
    }
}