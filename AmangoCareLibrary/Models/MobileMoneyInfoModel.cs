namespace AmangoCareLibrary.Models
{
    public class MobileMoneyInfoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MobileMoneyInfoId { get; set; }
        public string MobileMoneyInfoPhone { get; set; }
        public string MobileMoneyInfoCallsign { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; }
        public bool MobileMoneyInfoState { get; set; }
        public AccountModel Account { get; set; }
        public MobileMoneyTypeModel MobileMoneyType { get; set; }
    }   
}
