using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private ToDoListContext _toDoListContext;

        public CategoryRepository(ToDoListContext context)
        {
            _toDoListContext = context;
        }

        public List<SelectListItem> GetAll()
        {
            return _toDoListContext.Categories.Select(cat
                 => new SelectListItem
                 {
                     Text = cat.CategoryName,
                     Value = cat.Id.ToString()
                 }).ToList();
        }
    }
}
