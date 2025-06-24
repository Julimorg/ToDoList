using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Dto
{
    public class CreateUserDto
    {
        public string user_name { get; set; } = string.Empty;
        public string user_description { get; set; } = string.Empty;
        public string user_job { get; set; } = string.Empty;
        public string user_dob { get; set; } = string.Empty;
        public DateTime created_on { get; set; }
        public string user_phone { get; set; } = string.Empty;

    }
}