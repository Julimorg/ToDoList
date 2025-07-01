using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class DailyNote
    {
        public int id { get; set; }
        public string note_title { get; set; } = string.Empty;
        public string note_content { get; set; } = string.Empty;
        public DateTime create_at { get; set; }

        
    }
}