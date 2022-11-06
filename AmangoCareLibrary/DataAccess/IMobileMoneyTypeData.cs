namespace AmangoCareLibrary.DataAccess
{
    public interface IMobileMoneyTypeData
    {
        Task CreateMobileMoneyType(MobileMoneyTypeModel mobileMoneyType);
        Task<List<MobileMoneyTypeModel>> GetAllMobileMoneyTypes();
    }
}