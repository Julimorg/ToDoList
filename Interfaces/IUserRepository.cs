using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllByAsync();

        Task<User?> GetUserByIdAsync(int id);

        Task<User?> CreateUserAsync(User userModel);

        Task<User?> UpdateUserAsync(int id, UpdateUserDto updateUserDto);

        Task<User?> DeleteAsync(int id);

        Task<bool> UserExistsI(int id);
    }
}