using System;
using System.Threading.Tasks;
using ModulSchool.Models;

namespace ModulSchool.Services
{
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);
    }
    public async void AppendUser(User user)
    {
    using (var connection = new NpgsqlConnection(ConnectionString))
    {
    string query = "INSERT INTO users (id, email, nickname, phone) VALUES (@id, @email, @nickname, @phone)";
    
    await connection.QuerySingleAsync<User>(query, user);
    }
}
}
