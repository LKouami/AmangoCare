namespace AmangoCareLibrary.Models
{
    public class Benefit
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BenefitId { get; set; }
        public string BenefitNumber { get; set; }
        public string BenefitDescription { get; set; }
        public string BenefitAmount { get; set; }
        public DateTime BenefitDate { get; set; }
        public string BenefitCheckCode { get; set; }
        public string BenefitStateId { get; set; }
        public string AccountId { get; set; }
        public string HospitalId { get; set; }
        public string SubscriberId { get; set; }
    }
}
