using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data.Models;
using ToDoList.Data;

namespace ToDoList.Pages.Tasks
{
    public class EditTaskModel : PageModel
    {
        private IToDoTaskRepository _toDoTaskRepository;
        private IOwnerRepository _ownerRepository;
        private ICategoryRepository _categoryRepository;
        public EditTaskModel(IToDoTaskRepository toDoTaskRepository, IOwnerRepository ownerRepository, ICategoryRepository categoryRepository)
        {
            _toDoTaskRepository = toDoTaskRepository;
            _ownerRepository = ownerRepository;
            _categoryRepository = categoryRepository;
        }

        [FromRoute]
        public int Id { get; set; }
        [BindProperty]
        public ToDoTask ToDoTask { get; set; }
        public IActionResult OnGet()
        {
            ToDoTask = _toDoTaskRepository.GetById(Id);
            TempData["Owners"] = _ownerRepository.GetAll();
            TempData["Categories"] = _categoryRepository.GetAll();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ToDoTask.Id = Id;
                _toDoTaskRepository.Update(ToDoTask);
                return RedirectToPage("ViewAllTasks");

            }
            TempData["Owners"] = _ownerRepository.GetAll();
            TempData["Categories"] = _categoryRepository.GetAll();
            return Page();
        }
    }
}
