using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllByAsync();
    }
}