using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        private ToDoListContext _toDoListContext;

        public OwnerRepository(ToDoListContext context)
        {
            _toDoListContext = context;
        }

        public List<SelectListItem> GetAll()
        {
            List<SelectListItem> Owners = _toDoListContext.Owners
                     .Select(i => new SelectListItem
                     {
                         Value = i.Id.ToString(),
                         Text = i.Name
                     }).ToList();
            return Owners;
        }
        
    }
}
