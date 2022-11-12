namespace AmangoCareLibrary.Models
{
    public class HealthWorkerModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HealthWorkerId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public HospitalModel Hospital { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; }

    }
}
