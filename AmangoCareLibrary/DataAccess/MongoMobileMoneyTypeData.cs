namespace AmangoCareLibrary.DataAccess
{
    public class MongoMobileMoneyTypeData : IMobileMoneyTypeData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<MobileMoneyTypeModel> _mobileMoneyTypes;
        private const string cacheName = "MobileMoneyTypeData";

        public MongoMobileMoneyTypeData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _mobileMoneyTypes = db.MobileMoneyTypeCollection;
        }
        public async Task<List<MobileMoneyTypeModel>> GetAllMobileMoneyTypes()
        {
            var output = _cache.Get<List<MobileMoneyTypeModel>>(cacheName);

            if (output == null)
            {
                var results = await _mobileMoneyTypes.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateMobileMoneyType(MobileMoneyTypeModel mobileMoneyType)
        {
            return _mobileMoneyTypes.InsertOneAsync(mobileMoneyType);
        }
    }
}
