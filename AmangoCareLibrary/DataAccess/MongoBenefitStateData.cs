namespace AmangoCareLibrary.DataAccess
{
    public class MongoBenefitStateData : IBenefitStateData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<BenefitStateModel> _benefitStates;
        private const string cacheName = "BenefitStateData";

        public MongoBenefitStateData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _benefitStates = db.BenefitStateCollection;
        }
        public async Task<List<BenefitStateModel>> GetAllBenefitStates()
        {
            var output = _cache.Get<List<BenefitStateModel>>(cacheName);

            if (output == null)
            {
                var results = await _benefitStates.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateBenefitState(BenefitStateModel benefitState)
        {
            return _benefitStates.InsertOneAsync(benefitState);
        }
    }
}
