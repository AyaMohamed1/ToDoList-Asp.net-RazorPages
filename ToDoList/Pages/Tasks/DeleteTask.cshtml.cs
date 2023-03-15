using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data.Models;
using ToDoList.Data;

namespace ToDoList.Pages.Tasks
{
    public class DeleteTaskModel : PageModel
    {
        private IToDoTaskRepository _toDoTaskRepository;
        public DeleteTaskModel(IToDoTaskRepository toDoTaskRepository)
        {
            _toDoTaskRepository = toDoTaskRepository;
        }

        [FromRoute]
        public int Id { get; set; }
        [BindProperty]
        public ToDoTask DeleteToDoTask { get; set; }
        public void OnGet()
        {
            DeleteToDoTask = _toDoTaskRepository.GetById(Id);
        }
        public IActionResult OnPostDelete()
        {

                _toDoTaskRepository.Delete(Id);
                return RedirectToPage("ViewAllTasks");
        }
    }
}

