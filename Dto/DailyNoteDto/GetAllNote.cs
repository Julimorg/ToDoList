using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Dto.DailyNoteDto
{
    public class GetAllNote
    {
        public int id { get; set; }
        public string note_tilte { get; set; } = string.Empty;
        public string note_content { get; set; } = string.Empty;
    }
}