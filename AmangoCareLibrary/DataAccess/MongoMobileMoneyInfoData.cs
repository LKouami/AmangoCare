namespace AmangoCareLibrary.DataAccess
{
    public class MongoMobileMoneyInfoData : IMobileMoneyInfoData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<MobileMoneyInfoModel> _mobileMoneyInfos;
        private const string cacheName = "MobileMoneyInfoData";

        public MongoMobileMoneyInfoData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _mobileMoneyInfos = db.MobileMoneyInfoCollection;
        }
        public async Task<List<MobileMoneyInfoModel>> GetAllMobileMoneyInfos()
        {
            var output = _cache.Get<List<MobileMoneyInfoModel>>(cacheName);

            if (output == null)
            {
                var results = await _mobileMoneyInfos.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateMobileMoneyInfo(MobileMoneyInfoModel mobileMoneyInfo)
        {
            return _mobileMoneyInfos.InsertOneAsync(mobileMoneyInfo);
        }
    }
}
