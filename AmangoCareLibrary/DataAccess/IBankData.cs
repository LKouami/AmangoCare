namespace AmangoCareLibrary.DataAccess
{
    public interface IBankData
    {
        Task CreateBank(BankModel bank);
        Task<List<BankModel>> GetAllBanks();
    }
}