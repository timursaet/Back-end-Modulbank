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

    /*  public async Task<User> GetById(Guid id)
            {
                using (var connection = new NpgsqlConnection(ConnectionString))
                {
                    return await connection.QuerySingleAsync<User>(
                        "SELECT * FROM Users WHERE Id = @id", new {id});
                }
            }*/
    public async Task<User> GetById(Guid id)
    {
        User user = new User
        {
            Email    = "test@test.ru",
            Id       = id,
            Nickname = "test",
            Phone    = "+7 987 654 32 10"
        };

        return await Task.FromResult<User>(user);
    }

    }

}