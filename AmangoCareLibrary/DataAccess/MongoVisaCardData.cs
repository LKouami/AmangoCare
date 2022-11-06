namespace AmangoCareLibrary.DataAccess
{
    public class MongoVisaCardData : IVisaCardData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<VisaCardModel> _visaCards;
        private const string cacheName = "VisaCardData";

        public MongoVisaCardData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _visaCards = db.VisaCardCollection;
        }
        public async Task<List<VisaCardModel>> GetAllVisaCards()
        {
            var output = _cache.Get<List<VisaCardModel>>(cacheName);

            if (output == null)
            {
                var results = await _visaCards.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateVisaCard(VisaCardModel visaCard)
        {
            return _visaCards.InsertOneAsync(visaCard);
        }
    }
}
