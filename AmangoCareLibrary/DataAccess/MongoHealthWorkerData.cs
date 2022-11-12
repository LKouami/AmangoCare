namespace AmangoCareLibrary.DataAccess
{
    public class MongoHealthWorkerData : IHealthWorkerData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<HealthWorkerModel> _healthWorkers;
        private const string cacheName = "HealthWorkerData";
        public MongoHealthWorkerData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _healthWorkers = db.HealthWorkerCollection;
        }

        public async Task<List<HealthWorkerModel>> GetAllHealthWorkers()
        {
            var output = _cache.Get<List<HealthWorkerModel>>(cacheName);

            if (output == null)
            {
                var results = await _healthWorkers.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateHealthWorker(HealthWorkerModel healthWorker)
        {
            return _healthWorkers.InsertOneAsync(healthWorker);
        }
        public async Task UpdateHealthWorker(HealthWorkerModel healthWorker)
        {
            await _healthWorkers.ReplaceOneAsync(x => x.HealthWorkerId == healthWorker.HealthWorkerId, healthWorker);
            _cache.Remove(cacheName);
        }

    }
}
