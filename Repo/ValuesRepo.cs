using DevTrackerWebAPI.Data;
using DevTrackerWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DevTrackerWebAPI.Repo
{
    public class ValuesRepo : IValuesRepo
    {
        private readonly DataContext dataContext;

        public ValuesRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<Associate>> GetAssociatesAsync()
        {
            return await dataContext.Associates.ToListAsync();
        }

        async Task<IEnumerable<TaskType>> IValuesRepo.GetTaskTypesAsync()
        {
            return await dataContext.TaskTypes.ToListAsync();
        }
    }
}
