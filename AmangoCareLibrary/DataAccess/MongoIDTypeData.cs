namespace AmangoCareLibrary.DataAccess
{
    public class MongoIDTypeData : IIDTypeData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<IDTypeModel> _iDTypes;
        private const string cacheName = "IDTypeData";

        public MongoIDTypeData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _iDTypes = db.IDTypeCollection;
        }
        public async Task<List<IDTypeModel>> GetAllIDTypes()
        {
            var output = _cache.Get<List<IDTypeModel>>(cacheName);

            if (output == null)
            {
                var results = await _iDTypes.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateIDType(IDTypeModel iDType)
        {
            return _iDTypes.InsertOneAsync(iDType);
        }
    }
}
