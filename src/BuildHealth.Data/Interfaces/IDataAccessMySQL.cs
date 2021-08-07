using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildHealth.Data.Interfaces
{
    public interface IDataAccessMySQL
    {
        Task<List<T>> LoadData<T, U>(string command, U parameters, string connectionString);
        Task SaveData<T>(string command, T parameters, string connectionString);
    }
}