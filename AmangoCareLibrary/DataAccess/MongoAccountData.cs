namespace AmangoCareLibrary.DataAccess
{
    public class MongoAccountData : IAccountData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<AccountModel> _accounts;
        private const string cacheName = "AccountData";

        public MongoAccountData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _accounts = db.AccountCollection;
        }
        public async Task<List<AccountModel>> GetAllAccounts()
        {
            var output = _cache.Get<List<AccountModel>>(cacheName);

            if (output == null)
            {
                var results = await _accounts.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateAccount(AccountModel account)
        {
            return _accounts.InsertOneAsync(account);
        }
    }
}
