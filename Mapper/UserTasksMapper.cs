using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.Mapper
{
    public static class UserTasksMapper
    {
        public static GetUserTaskDto ToGetUserTaskDto(this UserTask userTaskModel)
        {
            return new GetUserTaskDto
            {
                Id = userTaskModel.Id,
                Title = userTaskModel.Title,
                Content = userTaskModel.Content,
                CreatedOn = userTaskModel.CreatedOn,
                UserId = userTaskModel.UserId,
            };
        }
    }
}