namespace AmangoCareLibrary.Models
{
    public class Subscriber
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubscriberId { get; set; }
        public string SubscriberName { get; set; }
        public string SubscriberFirstname { get; set; }
        public DateTime SubscriberBirthdate { get; set; }
        public string SubscriberEmail { get; set; }
        public string SubscriberPhone { get; set; }
        public string SubscriberAdress { get; set; }
        public string SubscriberIDNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public string SubscriberPersonalCode { get; set; }
        public bool SubscriberState { get; set; }
        public string IDTypeId { get; set; }
    }
}
