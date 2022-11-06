
namespace AmangoCareLibrary.DataAccess
{
    public class MongoUserData
    {
        private readonly IMongoCollection<UserModel> _users;

        public MongoUserData(IDbConnection db)
        {
            _users = db.UserCollection; 
        }

        public async Task<List<UserModel>> GetUserAsync()
        {
            var results = await _users.FindAsync(_ => true);
            return results.ToList();
        }
    }
}
