namespace AmangoCareLibrary.Models
{
    public class MobileMoneyInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MobileMoneyInfoId { get; set; }
        public string MobileMoneyInfoPhone { get; set; }
        public string MobileMoneyInfoCallsign { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; }
        public bool MobileMoneyInfoState { get; set; }
        public string AccountId { get; set; }
    }   
}
