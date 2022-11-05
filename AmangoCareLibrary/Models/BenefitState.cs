namespace AmangoCareLibrary.Models
{
    public class BenefitState
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BenefitStateId { get; set; }
        public string BenefitStateName { get; set; }
        public string BenefitStateDescription { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
