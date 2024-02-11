using DevTrackerWebAPI.Models;

namespace DevTrackerWebAPI.Repo
{
    public interface IValuesRepo
    {
        Task<IEnumerable<Associate>> GetAssociatesAsync();

        Task<IEnumerable<TaskType>> GetTaskTypesAsync();
    }
}
