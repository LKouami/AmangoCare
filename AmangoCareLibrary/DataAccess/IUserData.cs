namespace AmangoCareLibrary.DataAccess
{
    public interface IUserData
    {
        Task CreateUserAsync(UserModel user);
        Task<UserModel> GetUserAsync(string id);
        Task<UserModel> GetUserFromAuthenticationAsync(string id);
        Task<List<UserModel>> GetUsersAsync();
        Task UpdateUserAsync(UserModel user);
    }
}