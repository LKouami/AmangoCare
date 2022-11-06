using MongoDB.Driver;

namespace AmangoCareLibrary.DataAccess
{
    public interface IDbConnection
    {
        IMongoCollection<AccountModel> AccountCollection { get; }
        string AccountCollectionName { get; }
        IMongoCollection<BankModel> BankCollection { get; }
        string BankCollectionName { get; }
        IMongoCollection<BenefitModel> BenefitCollection { get; }
        string BenefitCollectionName { get; }
        IMongoCollection<BenefitStateModel> BenefitStateCollection { get; }
        string BenefitStateCollectionName { get; }
        MongoClient Client { get; }
        string DbName { get; }
        IMongoCollection<HospitalModel> HospitalCollection { get; }
        string HospitalCollectionName { get; }
        IMongoCollection<IDTypeModel> IDTypeCollection { get; }
        string IDTypeCollectionName { get; }
        IMongoCollection<MedicalRecordModel> MedicalRecordCollection { get; }
        string MedicalRecordCollectionName { get; }
        IMongoCollection<MobileMoneyInfoModel> MobileMoneyInfoCollection { get; }
        string MobileMoneyInfoCollectionName { get; }
        IMongoCollection<MobileMoneyTypeModel> MobileMoneyTypeCollection { get; }
        string MobileMoneyTypeCollectionName { get; }
        IMongoCollection<SubscriberModel> SubscriberCollection { get; }
        string SubscriberCollectionName { get; }
        IMongoCollection<UserModel> UserCollection { get; }
        string UserCollectionName { get; }
        IMongoCollection<VisaCardModel> VisaCardCollection { get; }
        string VisaCardCollectionName { get; }
    }
}