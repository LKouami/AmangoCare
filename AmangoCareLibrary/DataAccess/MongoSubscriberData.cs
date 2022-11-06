namespace AmangoCareLibrary.DataAccess
{
    public class MongoSubscriberData : ISubscriberData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<SubscriberModel> _subscribers;
        private const string cacheName = "SubscriberData";

        public MongoSubscriberData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _subscribers = db.SubscriberCollection;
        }
        public async Task<List<SubscriberModel>> GetAllSubscribers()
        {
            var output = _cache.Get<List<SubscriberModel>>(cacheName);

            if (output == null)
            {
                var results = await _subscribers.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateSubscriber(SubscriberModel subscriber)
        {
            return _subscribers.InsertOneAsync(subscriber);
        }
    }
}
