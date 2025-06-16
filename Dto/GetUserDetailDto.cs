using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Dto
{
    public class GetUserDetailDto
    {
        public int Id { get; set; }
        public string user_name { get; set; } = string.Empty;
        public string user_description { get; set; } = string.Empty;
        public string user_job { get; set; } = string.Empty;
        public string user_dob { get; set; } = string.Empty;
        public DateTime created_on { get; set; }
        public int user_phone { get; set; }
        
        public List<GetUserTaskDto> UserTasks { get; set; }
    }
}