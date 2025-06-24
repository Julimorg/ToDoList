using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Dto;
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

        [HttpPost]
        [Route("/user/create")]
        public async Task<IActionResult> Create([FromBody] CreateUserDto createUser)
        {
            var userModel = createUser.ToCreateUserDto();

            await _context.Users.AddAsync(userModel);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserById), new { id = userModel.Id }, userModel.ToGetUserDto());
        }

        [HttpPut]
        [Route("/user/update/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateUserDto updateUserDto)
        {
            var userModel = _context.Users.FirstOrDefault(s => s.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            userModel.user_name = updateUserDto.user_name;
            userModel.user_description = updateUserDto.user_description;
            userModel.user_job = updateUserDto.user_job;
            userModel.user_dob = updateUserDto.user_dob;
            userModel.user_phone = updateUserDto.user_phone;


            await _context.SaveChangesAsync();


            return Ok(userModel);
        }

        [HttpDelete]
        [Route("user/delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var userModel = _context.Users.FirstOrDefault(s => s.Id == id);

            if (userModel == null)
            {
                return NotFound();
            }

            _context.Users.RemoveRange(userModel);

            await _context.SaveChangesAsync();

            return Ok(userModel);

        }

        public Task<bool> UserExists(int id)
        {
            return _context.Users.AnyAsync(s => s.Id == id);
        }

    }
}