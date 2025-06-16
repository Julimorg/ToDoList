using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.Mapper
{
    public static class UserDetailMapper
    {
        public static GetUserDetailDto ToGetUserDetailDto(this User usermodel)
        {
            return new GetUserDetailDto
            {
                Id = usermodel.Id,
                user_name = usermodel.user_name,
                user_description = usermodel.user_description,
                user_dob = usermodel.user_description,
                user_job = usermodel.user_job,
                user_phone = usermodel.user_phone,
                UserTasks = usermodel.UserTasks.Select(c => c.ToGetUserTaskDto()).ToList()
            };
        }
    }
}