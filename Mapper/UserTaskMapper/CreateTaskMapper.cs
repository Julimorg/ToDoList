using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto.UsetTaskDto;
using ToDoList.Models;

namespace ToDoList.Mapper.UserTaskMapper
{
    public static  class CreateTaskMapper
    {
        public static UserTask ToCreateUserTaskDto(this CreateTaskDto createTaskDto, int userId)
        {
            return new UserTask
            {
                Title = createTaskDto.Title,
                Content = createTaskDto.Content,
                UserId = createTaskDto.UserId
            };
        }
        
    }
}