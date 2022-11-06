namespace AmangoCareLibrary.DataAccess
{
    public interface IMedicalRecordData
    {
        Task CreateMedicalRecord(MedicalRecordModel medicalRecord);
        Task<List<MedicalRecordModel>> GetAllMedicalRecords();
    }
}