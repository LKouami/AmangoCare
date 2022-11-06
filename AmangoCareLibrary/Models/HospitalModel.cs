namespace AmangoCareLibrary.Models
{
    public class HospitalModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalRaison { get; set; }
        public HashSet<string> HospitalPhones { get; set; } = new();
        public string HospitalAdress { get; set; }
        public string HospitalGeolocationLat { get; set; }
        public string HospitalGeolocationLong { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public bool HospitalState { get; set; }
        public List<BenefitModel> HospitalBenefits { get; set; } = new();
        public AccountModel Account { get; set; }

    }
}
