using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public interface ICategoryRepository
    {
        public List<SelectListItem> GetAll();
    }
}
