namespace AmangoCareLibrary.Models
{
    public class MedicalRecord
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
        public string MedicalRecordEmergencyContact1 { get; set; }
        public string MedicalRecordEmergencyContact2 { get; set; }
        public string MedicalRecordEmergencyContact3 { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;    
        public DateTime DateUpdated { get; set; }
    }
}
