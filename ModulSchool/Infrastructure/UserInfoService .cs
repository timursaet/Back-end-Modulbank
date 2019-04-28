using System;
using System.Threading.Tasks;
using ModulSchool.Models;
using ModulSchool.Services;
using Dapper;
using Npgsql;

namespace ModulSchool.Infrastructure
{
    public class UserInfoService : IUserInfoService
    {
        private const string ConnectionString =
            "host=localhost;port=5432;database=postgres;username=postgres;password=1";

      public async Task<User> GetById(Guid id)
            {
                using (var connection = new NpgsqlConnection(ConnectionString))
                {
                    return await connection.QuerySingleAsync<User>(
                        "SELECT * FROM Users WHERE Id = @id", new {id});
                }
            }

    }

}