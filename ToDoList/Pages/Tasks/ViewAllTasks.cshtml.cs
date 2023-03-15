using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;
using ToDoList.Data.Models;

namespace ToDoList.Pages.Tasks
{
    public class ViewAllTasksModel : PageModel
    {
        private IToDoTaskRepository _toDoTaskRepository;

        public List<ToDoTask> Tasks { get; set; }
        public ViewAllTasksModel(IToDoTaskRepository toDoTaskRepository)
        {
            _toDoTaskRepository = toDoTaskRepository;
        }
        public void OnGet()
        {
            Tasks = _toDoTaskRepository.GetAll();
        }
        public void OnPost()
        {
            //int x = int.Parse(Request.Form["ToDoTask.OwnerId"]);
        }
    }
}
