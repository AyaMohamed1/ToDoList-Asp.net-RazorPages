using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public interface IOwnerRepository
    {
        public List<SelectListItem> GetAll();
        //public List<Owner> GetAll();
    }
}
