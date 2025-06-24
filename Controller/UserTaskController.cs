using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Dto.UsetTaskDto;
using ToDoList.Mapper;
using ToDoList.Mapper.UserTaskMapper;


namespace ToDoList.Controller
{
    [Route("task/api")]
    [ApiController]
    public class UserTaskController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UserTaskController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id) {
           
            var taskModel = await _context.UserTasks.FindAsync(id);

            if (taskModel == null)
            {
                return NotFound();
            }

            return Ok(taskModel);

        } 

        [HttpPost]
        [Route("/create-task")]
        public async Task<IActionResult> Create([FromRoute] int userId, [FromBody] CreateTaskDto createTaskDto)
        {
            var taskModel = createTaskDto.ToCreateUserTaskDto(userId);

            await _context.UserTasks.AddAsync(taskModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById) ,new { id = taskModel.Id }, taskModel.ToGetUserTaskDto());
        }

    }
}