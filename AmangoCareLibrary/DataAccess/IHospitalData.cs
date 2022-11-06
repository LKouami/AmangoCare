namespace AmangoCareLibrary.DataAccess
{
    public interface IHospitalData
    {
        Task CreateHospital(HospitalModel hospital);
        Task<List<HospitalModel>> GetAllHospitals();
    }
}