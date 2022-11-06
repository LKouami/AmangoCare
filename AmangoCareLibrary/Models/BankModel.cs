namespace AmangoCareLibrary.Models
{
    public class BankModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankAccountRIB { get; set; }
        public string BankCodeSwift { get; set; }
        public bool BankState { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public AccountModel Account { get; set; }

    }
}
