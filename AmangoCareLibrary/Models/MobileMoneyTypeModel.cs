namespace AmangoCareLibrary.Models
{
    public class MobileMoneyTypeModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MobileMoneyTypeId { get; set; }
        public string MobileMoneyTypeName { get; set; }
        public string MobileMoneyTypeCountry { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public bool MobileMoneyTypeState { get; set; }
        public List<MobileMoneyInfoModel> mobileMoneyInfos { get; set; } = new();
    }
}
