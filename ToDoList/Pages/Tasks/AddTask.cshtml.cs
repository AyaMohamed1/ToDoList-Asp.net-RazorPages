using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Data.Models;

namespace ToDoList.Pages.Tasks
{
    public class AddTaskModel : PageModel
    {
        private IToDoTaskRepository _toDoTaskRepository;
        private IOwnerRepository _ownerRepository;
        private ICategoryRepository _categoryRepository;
        public AddTaskModel(IToDoTaskRepository toDoTaskRepository, IOwnerRepository ownerRepository,ICategoryRepository categoryRepository)
        {
            _toDoTaskRepository = toDoTaskRepository;
            _ownerRepository = ownerRepository;
            _categoryRepository = categoryRepository;
        }

        [BindProperty]
        public ToDoTask ToDoTask { get; set; }
        
        public IActionResult OnGet()
        {
            TempData["Owners"] = _ownerRepository.GetAll();
            TempData["Categories"] = _categoryRepository.GetAll();
            return Page();   
        }
        public IActionResult OnPost() {
            //int x = int.Parse(Request.Form["ToDoTask.OwnerId"]);
            if (ModelState.IsValid)
            {
                ToDoTask.AssignedDate = DateTime.Now;
                _toDoTaskRepository.Add(ToDoTask);
                return RedirectToPage("ViewAllTasks");

            }
            TempData["Owners"] = _ownerRepository.GetAll();
            TempData["Categories"] = _categoryRepository.GetAll() ;
            return Page();
        }
    }
}
