namespace AmangoCareLibrary.DataAccess
{
    public interface IMobileMoneyInfoData
    {
        Task CreateMobileMoneyInfo(MobileMoneyInfoModel mobileMoneyInfo);
        Task<List<MobileMoneyInfoModel>> GetAllMobileMoneyInfos();
    }
}