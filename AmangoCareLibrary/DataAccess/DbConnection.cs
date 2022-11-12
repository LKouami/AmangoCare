using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace AmangoCareLibrary.DataAccess
{
    public class DbConnection : IDbConnection
    {
        private readonly IConfiguration _config;
        private readonly IMongoDatabase _db;
        private string _connectionId = "MongoDB";
        public string DbName { get; private set; }
        public string IDTypeCollectionName { get; private set; } = "idtypes";
        public string AccountCollectionName { get; private set; } = "accounts";
        public string BankCollectionName { get; private set; } = "banks";
        public string BenefitCollectionName { get; private set; } = "benefits";
        public string BenefitStateCollectionName { get; private set; } = "benefitstates";
        public string HealthWorkerCollectionName { get; private set; } = "healthworkers";
        public string HospitalCollectionName { get; private set; } = "hospitals";
        public string MedicalRecordCollectionName { get; private set; } = "medicalrecords";
        public string MobileMoneyInfoCollectionName { get; private set; } = "mobilemoneyinfos";
        public string MobileMoneyTypeCollectionName { get; private set; } = "mobilemoneytypes";
        public string SubscriberCollectionName { get; private set; } = "subscribers";
        public string UserCollectionName { get; private set; } = "users";
        public string VisaCardCollectionName { get; private set; } = "visacards";

        public MongoClient Client { get; private set; }
        public IMongoCollection<IDTypeModel> IDTypeCollection { get; private set; }
        public IMongoCollection<AccountModel> AccountCollection { get; private set; }
        public IMongoCollection<BankModel> BankCollection { get; private set; }
        public IMongoCollection<BenefitModel> BenefitCollection { get; private set; }
        public IMongoCollection<BenefitStateModel> BenefitStateCollection { get; private set; }
        public IMongoCollection<HealthWorkerModel> HealthWorkerCollection { get; private set; }
        public IMongoCollection<HospitalModel> HospitalCollection { get; private set; }
        public IMongoCollection<MedicalRecordModel> MedicalRecordCollection { get; private set; }
        public IMongoCollection<MobileMoneyInfoModel> MobileMoneyInfoCollection { get; private set; }
        public IMongoCollection<MobileMoneyTypeModel> MobileMoneyTypeCollection { get; private set; }
        public IMongoCollection<SubscriberModel> SubscriberCollection { get; private set; }
        public IMongoCollection<UserModel> UserCollection { get; private set; }
        public IMongoCollection<VisaCardModel> VisaCardCollection { get; private set; }


        public DbConnection(IConfiguration config)
        {
            _config = config;
            Client = new MongoClient(_config.GetConnectionString(_connectionId));
            DbName = _config["DatabaseName"];
            _db = Client.GetDatabase(DbName);

            IDTypeCollection = _db.GetCollection<IDTypeModel>(IDTypeCollectionName);
            AccountCollection = _db.GetCollection<AccountModel>(AccountCollectionName);
            BankCollection = _db.GetCollection<BankModel>(BankCollectionName);
            BenefitCollection = _db.GetCollection<BenefitModel>(BenefitCollectionName);
            BenefitStateCollection = _db.GetCollection<BenefitStateModel>(BenefitStateCollectionName);
            HealthWorkerCollection = _db.GetCollection<HealthWorkerModel>(HealthWorkerCollectionName);
            HospitalCollection = _db.GetCollection<HospitalModel>(HospitalCollectionName);
            MedicalRecordCollection = _db.GetCollection<MedicalRecordModel>(MedicalRecordCollectionName);
            MobileMoneyInfoCollection = _db.GetCollection<MobileMoneyInfoModel>(MobileMoneyInfoCollectionName);
            MobileMoneyTypeCollection = _db.GetCollection<MobileMoneyTypeModel>(MobileMoneyTypeCollectionName);
            SubscriberCollection = _db.GetCollection<SubscriberModel>(SubscriberCollectionName);
            UserCollection = _db.GetCollection<UserModel>(UserCollectionName);
            VisaCardCollection = _db.GetCollection<VisaCardModel>(VisaCardCollectionName);


        }
    }
}
