namespace AmangoCareLibrary.DataAccess
{
    public interface IBenefitData
    {
        Task CreateBenefit(BenefitModel benefit);
        Task<List<BenefitModel>> GetAllBenefits();
    }
}