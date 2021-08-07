using BuildHealth.Data.Interfaces;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BuildHealth.Data
{
    public class DataAccessMySQL : IDataAccessMySQL
    {
        public async Task<List<T>> LoadData<T, U>(string command, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(command, parameters);
                return rows.ToList();
            }
        }

        public Task SaveData<T>(string command, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(command, parameters);
            }
        }
    }
}
