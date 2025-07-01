using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Dto.DailyNoteDto;
using ToDoList.Models;

namespace ToDoList.Mapper.DailyNoteMapper
{
    public static class GetNoteMapper 
    {
        public static GetAllNote ToGetAllNoteDto(this DailyNote dailyNoteModel)
        {
            return new GetAllNote
            {
                id = dailyNoteModel.id,
                note_tilte = dailyNoteModel.note_title,
                note_content = dailyNoteModel.note_content
            };
        }
    }
}