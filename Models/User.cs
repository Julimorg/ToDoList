using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class User
    {
        public int Id { get; set; }
        public string user_name { get; set; } = string.Empty;
        public string user_description { get; set; } = string.Empty;
        public string user_job { get; set; } = string.Empty;
        public DateTime user_dob { get; set; }
        public DateTime created_on { get; set; }
        public int user_phone { get; set; }

        public List<UserTask> UserTasks { get; set; } = new List<UserTask>();
    }
}