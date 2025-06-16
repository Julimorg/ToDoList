using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.Mapper
{
    public static class UserMapper
    {
        public static GetUsersDto ToGetUserDto(this User userModel)
        {
            return new GetUsersDto
            {
                Id = userModel.Id,
                user_name = userModel.user_name,
                user_description = userModel.user_description,
                user_job = userModel.user_job,
                user_dob = userModel.user_dob,
                user_phone = userModel.user_phone,
                created_on = userModel.created_on,
            };
        }
    }
}