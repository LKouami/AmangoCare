namespace AmangoCareLibrary.Models
{
    public class Hospital
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalRaison { get; set; }
        public string HospitalPhone { get; set; }
        public string HospitalAdress { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public bool HospitalState { get; set; }

    }
}
