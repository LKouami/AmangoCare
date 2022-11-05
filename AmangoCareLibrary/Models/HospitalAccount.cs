namespace AmangoCareLibrary.Models
{
    public class HospitalAccount
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HospitalAccountId { get; set; }
        public string HospitalAccountNumber { get; set; }
        public float HospitalAccountBalance { get; set; }
        public bool HospitalAccountState { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public string HospitalId { get; set; }


    }
}
