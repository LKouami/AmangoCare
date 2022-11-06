namespace AmangoCareLibrary.Models
{
    public class SubscriberModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubscriberId { get; set; }
        public string SubscriberName { get; set; }
        public string SubscriberFirstname { get; set; }
        public DateTime SubscriberBirthdate { get; set; }
        public string SubscriberEmail { get; set; }
        public HashSet<string> SubscriberPhones { get; set; }=new();    
        public string SubscriberAdress { get; set; }
        public string SubscriberGeolocationLat { get; set; }
        public string SubscriberGeolocationLong { get; set; }
        public string SubscriberIDNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public string SubscriberPersonalCode { get; set; }
        public bool SubscriberState { get; set; }
        public IDTypeModel IDType { get; set; }
        public List<BenefitModel> Benefits { get; set; } = new();
        public AccountModel Account { get; set; }
        public MedicalRecordModel MedicalRecord { get; set; }


    }
}
