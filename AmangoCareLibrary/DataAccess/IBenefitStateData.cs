namespace AmangoCareLibrary.DataAccess
{
    public interface IBenefitStateData
    {
        Task CreateBenefitState(BenefitStateModel benefitState);
        Task<List<BenefitStateModel>> GetAllBenefitStates();
    }
}