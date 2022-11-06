namespace AmangoCareLibrary.DataAccess
{
    public interface IVisaCardData
    {
        Task CreateVisaCard(VisaCardModel visaCard);
        Task<List<VisaCardModel>> GetAllVisaCards();
    }
}