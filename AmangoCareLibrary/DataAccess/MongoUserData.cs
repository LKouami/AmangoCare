﻿
namespace AmangoCareLibrary.DataAccess
{
    public class MongoUserData : IUserData
    {
        private readonly IMongoCollection<UserModel> _users;

        public MongoUserData(IDbConnection db)
        {
            _users = db.UserCollection;
        }

        public async Task<List<UserModel>> GetUsersAsync()
        {
            var results = await _users.FindAsync(_ => true);
            return results.ToList();
        }
        public async Task<UserModel> GetUserAsync(string id)
        {
            var results = await _users.FindAsync(u => u.Id == id);
            return results.FirstOrDefault();
        }
        public async Task<UserModel> GetUserFromAuthenticationAsync(string id)
        {
            var results = await _users.FindAsync(u => u.Id == id);
            return results.FirstOrDefault();
        }
        public Task CreateUserAsync(UserModel user)
        {
            return _users.InsertOneAsync(user);
        }
        public Task UpdateUserAsync(UserModel user)
        {
            var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
            return _users.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true });
        }
    }
}
