namespace AmangoCareLibrary.Models
{
    public class VisaCardModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string VisaCardId { get; set; }
        public string VisaCardNumber { get; set; }
        public DateTime VisaCardExpirationDate { get; set; } = DateTime.UtcNow;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; }
        public bool VisaCardState { get; set; }
        public AccountModel Account { get; set; }
    }
}
