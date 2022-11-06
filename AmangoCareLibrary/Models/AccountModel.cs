namespace AmangoCareLibrary.Models
{
    public class AccountModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AccountId { get; set; }
        public string AccountNumber { get; set; }
        public float AccountBalance { get; set; }
        public bool AccountState { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public HospitalModel Hospital { get; set; }
        public SubscriberModel Subscriber { get; set; }
        public BankModel Bank { get; set; }
        public MobileMoneyInfoModel MobileMoneyInfo { get; set; }
        public VisaCardModel VisaCard { get; set; }
        public List<BenefitModel> Benefits { get; set; } = new();




    }
}
