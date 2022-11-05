namespace AmangoCareLibrary.Models
{
    public class SubscriberAccount
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubscriberAccountId { get; set; }
        public string SubscriberAccountNumber { get; set; }
        public float SubscriberAccountBalance { get; set; }
        public bool SubscriberAccountState { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public string SubscriberId { get; set; }


    }
}
