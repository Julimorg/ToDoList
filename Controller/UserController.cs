using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Mapper;
using ToDoList.Models;

namespace ToDoList.Controller
{
    [Route("user/api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var users = await _context.Users.ToListAsync();
            
            var userDto = users.Select(s => s.ToGetUserDto());

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            var users = await _context.Users.FindAsync(id);
            
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users); 
        }
    }
}