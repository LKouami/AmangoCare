namespace AmangoCareLibrary.DataAccess
{
    public interface IAccountData
    {
        Task CreateAccount(AccountModel account);
        Task<List<AccountModel>> GetAllAccounts();
    }
}