namespace AmangoCareLibrary.DataAccess
{
    public class MongoBankData : IBankData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<BankModel> _banks;
        private const string cacheName = "BankData";

        public MongoBankData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _banks = db.BankCollection;
        }
        public async Task<List<BankModel>> GetAllBanks()
        {
            var output = _cache.Get<List<BankModel>>(cacheName);

            if (output == null)
            {
                var results = await _banks.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateBank(BankModel bank)
        {
            return _banks.InsertOneAsync(bank);
        }
    }
}
