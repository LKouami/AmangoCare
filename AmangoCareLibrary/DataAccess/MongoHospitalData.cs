namespace AmangoCareLibrary.DataAccess
{
    public class MongoHospitalData : IHospitalData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<HospitalModel> _hospitals;
        private const string cacheName = "HospitalData";

        public MongoHospitalData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _hospitals = db.HospitalCollection;
        }
        public async Task<List<HospitalModel>> GetAllHospitals()
        {
            var output = _cache.Get<List<HospitalModel>>(cacheName);

            if (output == null)
            {
                var results = await _hospitals.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateHospital(HospitalModel hospital)
        {
            return _hospitals.InsertOneAsync(hospital);
        }
    }
}
