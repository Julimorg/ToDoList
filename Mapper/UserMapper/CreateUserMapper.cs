using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.Mapper
{
    public static class CreateUserMapper
    {
        public static User ToCreateUserDto(this CreateUserDto userDto)
        {
            return new User
            {
                user_name = userDto.user_name,
                user_description = userDto.user_description,
                user_dob = userDto.user_dob,
                user_job = userDto.user_job,
                created_on = userDto.created_on,
                user_phone = userDto.user_phone,
            };
        }
    }
}