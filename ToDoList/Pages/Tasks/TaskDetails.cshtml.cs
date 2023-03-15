using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data.Models;
using ToDoList.Data;

namespace ToDoList.Pages.Tasks
{
    public class TaskDetailsModel : PageModel
    {
        private IToDoTaskRepository _toDoTaskRepository;
        public TaskDetailsModel(IToDoTaskRepository toDoTaskRepository)
        {
            _toDoTaskRepository = toDoTaskRepository;
        }

        [FromRoute]
        public int Id { get; set; }
        public ToDoTask DetailsToDoTask { get; set; }
        public void OnGet()
        {
            DetailsToDoTask = _toDoTaskRepository.GetById(Id);
        }
        
    }
}

