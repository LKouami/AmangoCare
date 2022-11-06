namespace AmangoCareLibrary.DataAccess
{
    public class MongoMedicalRecordData : IMedicalRecordData
    {
        private readonly IMemoryCache _cache;
        private readonly IMongoCollection<MedicalRecordModel> _medicalRecords;
        private const string cacheName = "MedicalRecordData";

        public MongoMedicalRecordData(IDbConnection db, IMemoryCache cache)
        {
            _cache = cache;
            _medicalRecords = db.MedicalRecordCollection;
        }
        public async Task<List<MedicalRecordModel>> GetAllMedicalRecords()
        {
            var output = _cache.Get<List<MedicalRecordModel>>(cacheName);

            if (output == null)
            {
                var results = await _medicalRecords.FindAsync(_ => true);
                output = results.ToList();

                _cache.Set(cacheName, output, TimeSpan.FromDays(1));
            }
            return output;
        }
        public Task CreateMedicalRecord(MedicalRecordModel medicalRecord)
        {
            return _medicalRecords.InsertOneAsync(medicalRecord);
        }
    }
}
