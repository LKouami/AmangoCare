namespace AmangoCareLibrary.DataAccess
{
    public class MongoBenefitData : IBenefitData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<BenefitModel> _benefits;
        private const string cacheName = "BenefitData";

        public MongoBenefitData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _benefits = db.BenefitCollection;
        }
        public async Task<List<BenefitModel>> GetAllBenefits()
        {
            var output = _cache.Get<List<BenefitModel>>(cacheName);

            if (output == null)
            {
                var results = await _benefits.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateBenefit(BenefitModel benefit)
        {
            return _benefits.InsertOneAsync(benefit);
        }
    }
}
