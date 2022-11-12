namespace AmangoCareLibrary.DataAccess
{
    public interface IHealthWorkerData
    {
        Task CreateHealthWorker(HealthWorkerModel healthWorker);
        Task<List<HealthWorkerModel>> GetAllHealthWorkers();
        Task UpdateHealthWorker(HealthWorkerModel healthWorker);
    }
}