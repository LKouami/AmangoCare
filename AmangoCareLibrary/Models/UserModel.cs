namespace AmangoCareLibrary.Models
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ObjectIdentifier { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAdress { get; set; }
    }
}
