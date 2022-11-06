namespace AmangoCareLibrary.Models
{
    public class BenefitStateModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BenefitStateId { get; set; }
        public string BenefitStateName { get; set; }
        public string BenefitStateDescription { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public List<BenefitModel> Benefits { get; set; } = new();

    }
}
