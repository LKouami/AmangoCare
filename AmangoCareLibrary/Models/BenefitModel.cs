namespace AmangoCareLibrary.Models
{
    public class BenefitModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BenefitId { get; set; }
        public string BenefitNumber { get; set; }
        public string BenefitDescription { get; set; }
        public string BenefitAmount { get; set; }
        public DateTime BenefitDate { get; set; }
        public string BenefitCheckCode { get; set; }
        public BenefitStateModel BenefitState { get; set; }
        public AccountModel Account { get; set; }
        public HospitalModel Hospital { get; set; }
        public SubscriberModel Subscriber { get; set; }
    }
}
