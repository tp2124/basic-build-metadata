using BuildHealth.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildHealth.Data.Interfaces
{
    public interface IBuildResultDataService
    {
        Task<List<BuildResultModel>> GetBuilds();
        Task SaveBuildResults(List<BuildResultModel> newData);
    }
}