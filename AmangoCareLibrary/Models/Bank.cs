namespace AmangoCareLibrary.Models
{
    public class Bank
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankCodeSwift { get; set; }
        public bool BankState { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public string BankId { get; set; }

    }
}
