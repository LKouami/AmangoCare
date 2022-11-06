namespace AmangoCareLibrary.DataAccess
{
    public interface IIDTypeData
    {
        Task CreateIDType(IDTypeModel iDType);
        Task<List<IDTypeModel>> GetAllIDTypes();
    }
}