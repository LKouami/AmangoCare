namespace AmangoCareLibrary.Models
{
    public class MedicalRecordModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MedicalRecordId { get; set; }
        public string MedicalRecordBloodGroup { get; set; }
        public string MedicalRecordAllergy { get; set; }
        public string MedicalRecordOngoingTreatment { get; set; }
        public string MedicalRecordWeight { get; set; }
        public string MedicalRecordHeight { get; set; }
        public string MedicalRecordRecommendation { get; set; }
        public bool MedicalRecordOrganDonor { get; set; }
        public HashSet<string> MedicalRecordEmergencyContact { get; set; }= new();
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
        public SubscriberModel Subscriber { get; set; }
    }
}
