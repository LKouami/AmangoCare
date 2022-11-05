namespace AmangoCareLibrary.Models
{
    public class IDType
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IDTypeId { get; set; }
        public string IDTypeName { get; set; }
        public bool IDTypeState { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
