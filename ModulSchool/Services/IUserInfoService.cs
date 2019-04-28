using System;
using System.Threading.Tasks;
using ModulSchool.Models;

namespace ModulSchool.Services
{
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);
    }
}
